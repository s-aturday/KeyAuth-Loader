using KeyAuth;
using Microsoft.VisualBasic.Logging;

namespace hyst
{
    internal static class Program
    {
        public static api CTA = new api(
            name: "Example",
            ownerid: "Example",
            secret: "Example",
            version: "1.0"
        );

        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            CTA.init();
        }
    }
}