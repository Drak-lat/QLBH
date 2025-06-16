namespace QLBH
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            fLogin f = new fLogin();
            if (f.ShowDialog() == DialogResult.OK)
                Application.Run(new fMain());

        }
    }
}