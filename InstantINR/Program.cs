namespace InstantINR
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Catch UI thread exceptions.
            Application.ThreadException += (sender, e) =>
            {
                HandleException(e.Exception);
            };

            // Catch non-UI thread exceptions.
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                HandleException((Exception)e.ExceptionObject);
            };

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);


            Application.Run(new MainView());
        }

        private static void HandleException(Exception exception)
        {
            string message = exception.Message;
            var innerException = exception.InnerException;
            while (innerException != null)
            {
                message += Environment.NewLine + innerException.Message;
                innerException = innerException.InnerException;
            }

            MessageBox.Show(message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}