namespace InstantINR
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            tabControl = new TabControl();
            tabPageCalculator = new TabPage();
            buttonRefresh = new Button();
            labelQcUpdatedDateTime = new Label();
            labelMnptValue = new Label();
            labelIsiValue = new Label();
            label1 = new Label();
            textBoxInr = new TextBox();
            textBoxPt = new TextBox();
            labelINR = new Label();
            labelPT = new Label();
            label2 = new Label();
            tabPageSettings = new TabPage();
            label3 = new Label();
            label4 = new Label();
            textBoxIsi = new TextBox();
            textBoxMnpt = new TextBox();
            tabPageAbout = new TabPage();
            label5 = new Label();
            tabControl.SuspendLayout();
            tabPageCalculator.SuspendLayout();
            tabPageSettings.SuspendLayout();
            tabPageAbout.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageCalculator);
            tabControl.Controls.Add(tabPageSettings);
            tabControl.Controls.Add(tabPageAbout);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(268, 137);
            tabControl.TabIndex = 0;
            // 
            // tabPageCalculator
            // 
            tabPageCalculator.Controls.Add(buttonRefresh);
            tabPageCalculator.Controls.Add(labelQcUpdatedDateTime);
            tabPageCalculator.Controls.Add(labelMnptValue);
            tabPageCalculator.Controls.Add(labelIsiValue);
            tabPageCalculator.Controls.Add(label1);
            tabPageCalculator.Controls.Add(textBoxInr);
            tabPageCalculator.Controls.Add(textBoxPt);
            tabPageCalculator.Controls.Add(labelINR);
            tabPageCalculator.Controls.Add(labelPT);
            tabPageCalculator.Controls.Add(label2);
            tabPageCalculator.Location = new Point(4, 25);
            tabPageCalculator.Name = "tabPageCalculator";
            tabPageCalculator.Padding = new Padding(3);
            tabPageCalculator.Size = new Size(260, 108);
            tabPageCalculator.TabIndex = 0;
            tabPageCalculator.Text = "Calculator";
            tabPageCalculator.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Image = (Image)resources.GetObject("buttonRefresh.Image");
            buttonRefresh.Location = new Point(190, 47);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(30, 30);
            buttonRefresh.TabIndex = 9;
            buttonRefresh.TabStop = false;
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // labelQcUpdatedDateTime
            // 
            labelQcUpdatedDateTime.AutoSize = true;
            labelQcUpdatedDateTime.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelQcUpdatedDateTime.Location = new Point(21, 83);
            labelQcUpdatedDateTime.Name = "labelQcUpdatedDateTime";
            labelQcUpdatedDateTime.Size = new Size(91, 16);
            labelQcUpdatedDateTime.TabIndex = 8;
            labelQcUpdatedDateTime.Tag = "i";
            labelQcUpdatedDateTime.Text = "QC Updated @";
            // 
            // labelMnptValue
            // 
            labelMnptValue.AutoSize = true;
            labelMnptValue.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMnptValue.Location = new Point(62, 47);
            labelMnptValue.Name = "labelMnptValue";
            labelMnptValue.Size = new Size(35, 16);
            labelMnptValue.TabIndex = 7;
            labelMnptValue.Tag = "b";
            labelMnptValue.Text = "0.00";
            // 
            // labelIsiValue
            // 
            labelIsiValue.AutoSize = true;
            labelIsiValue.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIsiValue.Location = new Point(62, 63);
            labelIsiValue.Name = "labelIsiValue";
            labelIsiValue.Size = new Size(35, 16);
            labelIsiValue.TabIndex = 6;
            labelIsiValue.Tag = "b";
            labelIsiValue.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 47);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 4;
            label1.Tag = "b";
            label1.Text = "MNPT:";
            // 
            // textBoxInr
            // 
            textBoxInr.Location = new Point(154, 14);
            textBoxInr.Name = "textBoxInr";
            textBoxInr.Size = new Size(66, 21);
            textBoxInr.TabIndex = 3;
            textBoxInr.TabStop = false;
            // 
            // textBoxPt
            // 
            textBoxPt.Location = new Point(48, 14);
            textBoxPt.Name = "textBoxPt";
            textBoxPt.Size = new Size(66, 21);
            textBoxPt.TabIndex = 2;
            // 
            // labelINR
            // 
            labelINR.AutoSize = true;
            labelINR.Location = new Point(120, 17);
            labelINR.Name = "labelINR";
            labelINR.Size = new Size(28, 16);
            labelINR.TabIndex = 1;
            labelINR.Text = "INR";
            // 
            // labelPT
            // 
            labelPT.AutoSize = true;
            labelPT.Location = new Point(21, 17);
            labelPT.Name = "labelPT";
            labelPT.Size = new Size(21, 16);
            labelPT.TabIndex = 0;
            labelPT.Text = "PT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 63);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 5;
            label2.Tag = "b";
            label2.Text = "ISI:";
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(label3);
            tabPageSettings.Controls.Add(label4);
            tabPageSettings.Controls.Add(textBoxIsi);
            tabPageSettings.Controls.Add(textBoxMnpt);
            tabPageSettings.Location = new Point(4, 24);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(3);
            tabPageSettings.Size = new Size(260, 109);
            tabPageSettings.TabIndex = 1;
            tabPageSettings.Text = "Settings";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 13);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 6;
            label3.Tag = "b";
            label3.Text = "MNPT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 43);
            label4.Name = "label4";
            label4.Size = new Size(35, 16);
            label4.TabIndex = 7;
            label4.Tag = "b";
            label4.Text = "ISI:";
            // 
            // textBoxIsi
            // 
            textBoxIsi.Location = new Point(56, 40);
            textBoxIsi.Name = "textBoxIsi";
            textBoxIsi.Size = new Size(66, 21);
            textBoxIsi.TabIndex = 5;
            // 
            // textBoxMnpt
            // 
            textBoxMnpt.Location = new Point(56, 13);
            textBoxMnpt.Name = "textBoxMnpt";
            textBoxMnpt.Size = new Size(66, 21);
            textBoxMnpt.TabIndex = 4;
            // 
            // tabPageAbout
            // 
            tabPageAbout.Controls.Add(label5);
            tabPageAbout.Location = new Point(4, 24);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Padding = new Padding(3);
            tabPageAbout.Size = new Size(260, 109);
            tabPageAbout.TabIndex = 2;
            tabPageAbout.Text = "About";
            tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 5);
            label5.Name = "label5";
            label5.Size = new Size(217, 96);
            label5.TabIndex = 1;
            label5.Text = "Calculates INR and copies the \r\nvalue to clipboard.\r\nINR = (Patient PT/MNPT)^ISI\r\n\r\nIbrahim Hussain\r\nibrahim.hucyn@live.com";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 137);
            Controls.Add(tabControl);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainView";
            Text = "Instant INR";
            TopMost = true;
            tabControl.ResumeLayout(false);
            tabPageCalculator.ResumeLayout(false);
            tabPageCalculator.PerformLayout();
            tabPageSettings.ResumeLayout(false);
            tabPageSettings.PerformLayout();
            tabPageAbout.ResumeLayout(false);
            tabPageAbout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageCalculator;
        private TabPage tabPageSettings;
        private TabPage tabPageAbout;
        private Label label2;
        private Label label1;
        private TextBox textBoxInr;
        private TextBox textBoxPt;
        private Label labelINR;
        private Label labelPT;
        private Label labelQcUpdatedDateTime;
        private Label labelMnptValue;
        private Label labelIsiValue;
        private Button buttonRefresh;
        private TextBox textBoxMnpt;
        private Label label3;
        private Label label4;
        private TextBox textBoxIsi;
        private Label label5;
    }
}