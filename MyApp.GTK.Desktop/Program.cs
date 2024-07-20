using Gtk;
using MyApp.GTK.Views;
using System;

namespace MyApp.GTK.Desktop
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.MyApp.GTK.MyApp.GTK", GLib.ApplicationFlags.None);
            ////app.Register(GLib.Cancellable.Current); // Отмена запуска второго и более экземпляра приложения

            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}
