using System;
using System.Windows.Forms;

namespace CyberSecurity_Awareness_chatbot
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AssistantForm());
        }
    }
}
