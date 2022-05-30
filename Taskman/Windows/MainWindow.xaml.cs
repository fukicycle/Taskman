using System;
using System.Collections.Generic;
using System.IO;
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

namespace Taskman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new
            {
                Source = File.ReadAllBytes(@"Images\android.png"),
                ViewTop = SystemParameters.PrimaryScreenHeight - 250,
                ViewLeft = SystemParameters.PrimaryScreenWidth - 220
            };
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {

        }

        private void OverrideMsgMenuClick(object sender, RoutedEventArgs e)
        {

        }

        private void AddMsgMenuClick(object sender, RoutedEventArgs e)
        {

        }

        private void InformationMenuClick(object sender, RoutedEventArgs e)
        {

        }

        private void ShutdownMenuClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
