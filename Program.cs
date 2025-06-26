using System;
using System.Windows.Forms;

namespace CyberSecurity_Awareness_chatbot
{
    internal static class Program
    {
        /// <summary>
        ///  Main entry point of the CyberSecurity Awareness Chatbot application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Launch the main assistant form
                Application.Run(new AssistantForm());
            }
            catch (Exception ex)
            {
                // Log or handle errors gracefully
                MessageBox.Show(
                    "An error occurred while launching the Assistant.\n\n" + ex.Message,
                    "Startup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                // Optionally, fall back to the QuizForm
                // Application.Run(new QuizForm());
            }
        }
    }
}
