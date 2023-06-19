using InstantINR.InstantINR;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace InstantINR
{
    public partial class MainView : Form
    {
        private Client _apiClient;

        private event EventHandler InitializeData;
        public MainView()
        {
            InitializeComponent();
            Load += MainView_Load_InitializeFont;
            KeyUp += MainView_KeyUp;
            InitializeHttpClient();

            InitializeData += GetInrDataAsync;
            buttonRefresh.Click += GetInrDataAsync;
            textBoxIsi.Validated += SaveInrDataAsync;
            textBoxMnpt.Validated += SaveInrDataAsync;

            InitializeData?.Invoke(this, EventArgs.Empty);
            textBoxPt.Focus();
        }

        private void InitializeHttpClient()
        {
            //get base url from settings
            var baseUrl = Properties.Settings.Default.ApiBaseUrl;
            // Initialize the API client
            var httpClient = new HttpClient();
            _apiClient = new Client(baseUrl, httpClient);
        }

        private async void MainView_KeyUp(object? sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                KeyUp -= MainView_KeyUp;

                CalculateInr();

                await Task.Delay(100);
                KeyUp += MainView_KeyUp;
            }


        }

        private void CalculateInr()
        {
            try
            {
                // INR = (PT/MNPT)^ISI
                //use tryPrase to validate values and assign to variables and use the formula to calculate
                if (double.TryParse(textBoxPt.Text, out double pt) &&
                                       double.TryParse(textBoxMnpt.Text, out double mnpt) &&
                                                          double.TryParse(textBoxIsi.Text, out double isi))
                {
                    double inr = Math.Pow(pt / mnpt, isi);
                    textBoxInr.Text = inr.ToString("0.00");
                    Clipboard.SetText(Text = inr.ToString("0.00"));
                }
                else
                {
                    textBoxInr.Text = string.Empty;
                    MessageBox.Show("Please enter valid values for PT, MNPT, and ISI\nPlease press [Esc] on keyboard.",
                                    "Invalid values",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region Font Management
        private void MainView_Load_InitializeFont(object? sender, EventArgs e)
        {
            string fontResourceName = "InstantINR.CascadiaCode.ttf";

            PrivateFontCollection pfc;
            FontFamily ff = LoadFontFamilyFromResource(fontResourceName, out pfc);

            Font myFont = new Font(ff, 9, FontStyle.Regular); // Create the font

            SetFontForAllControls(this, myFont);
        }
        private FontFamily LoadFontFamilyFromResource(string resourceName, out PrivateFontCollection fontCollection)
        {
            fontCollection = new PrivateFontCollection();

            // Get the font resource as a Stream
            var fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);

            // Create a byte array to hold the font data
            byte[] fontData = new byte[fontStream.Length];

            // Fill the byte array with the font data from the Stream
            fontStream.Read(fontData, 0, (int)fontStream.Length);

            // Allocate some unmanaged memory for the font data and copy the font data to it
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            // Add the font data to the PrivateFontCollection
            fontCollection.AddMemoryFont(fontPtr, fontData.Length);

            // Free the unmanaged memory
            Marshal.FreeCoTaskMem(fontPtr);

            return fontCollection.Families[0];
        }
        private void SetFontForAllControls(Control control, Font font)
        {
            foreach (Control c in control.Controls)
            {
                // Only change the Font property for control types that are known to have it.
                if (c is Button ||
                    c is Label ||
                    c is TextBox ||
                    c is CheckBox ||
                    c is RadioButton ||
                    c is GroupBox ||
                    c is ListBox ||
                    c is ComboBox ||
                    c is DataGridView ||
                    c is MenuStrip)
                {
                    if (c.Tag?.ToString() == "b")
                    {
                        c.Font = new Font(font, FontStyle.Bold);
                    }
                    else if (c.Tag?.ToString() == "i")
                    {
                        c.Font = new Font(font, FontStyle.Italic);
                    }
                    else
                    {
                        c.Font = font;
                    }
                }






                // Call this function again to set the font for nested controls.
                SetFontForAllControls(c, font);
            }
        }

        #endregion


        private async void GetInrDataAsync(object sender, EventArgs e)
        {
            try
            {
                // Call the GetInrDataAsync method
                var data = await _apiClient.GetInrDataAsync();
                if (data is null)
                {
                    MessageBox.Show("Unable to get saved MNPT and ISI");
                    SetUiIsiAndMnpt(0.00, 0.00);
                    return;
                }

                SetUiIsiAndMnpt(data.Mnpt, data.Isi);
            }
            catch (ApiException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void SetUiIsiAndMnpt(double mnpt, double isi)
        {
            labelMnptValue.Text = mnpt.ToString();
            labelIsiValue.Text = isi.ToString();
            textBoxMnpt.Text = mnpt.ToString();
            textBoxIsi.Text = isi.ToString();
        }

        private async void SaveInrDataAsync(object sender, EventArgs e)
        {
            try
            {
                // Create a new InrDataModel instance
                var data = new InrDataModel
                {
                    Mnpt = double.Parse(textBoxMnpt.Text),
                    Isi = double.Parse(textBoxIsi.Text),
                    DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };
                // Call the PostInrDataAsync method
                await _apiClient.PostInrDataAsync(data);

                //success
                SetUiIsiAndMnpt(data.Mnpt, data.Isi);
            }
            catch (ApiException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
