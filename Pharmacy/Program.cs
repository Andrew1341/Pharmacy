using Pharmacy.Model;
using Pharmacy;
using Gtk;

internal class Program
{
    private static void Main(string[] args)
    {
        Application.Init();
        var mainWindow = new MainWindow();
        mainWindow.ShowAll();
        Application.Run();
    }
}