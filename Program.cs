using rm;
using System.Threading;
using System.Windows.Forms;
using System;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
        Application.Run(new Form1());
    }

    static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        MessageBox.Show("Unhandled Error: " + e.Exception.Message);
    }
}