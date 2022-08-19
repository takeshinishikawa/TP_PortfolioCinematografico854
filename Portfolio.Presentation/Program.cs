using Portfolio.Domain;
using Portfolio.Domain.Enum;

namespace Portfolio.Presentation;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    //[STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new @ref());
        
        
    }
}