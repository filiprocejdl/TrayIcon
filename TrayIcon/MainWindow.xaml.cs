using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hardcodet.Wpf.TaskbarNotification;

namespace TrayIcon
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Minimalizer();


            List<ICommand> Action = new List<ICommand>(){new Open(this), new Close()};


            ContextMenu menu = new ContextMenu();
            menu.ItemsSource = Action;
            NotifyIcon.ContextMenu = menu;


            

        }

        void Minimalizer()
        {
           //this.WindowState = FormWindowState.Minimized;
        }

        private void Button_Test(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
