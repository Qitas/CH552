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


namespace Qitas
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FunctionTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (functionTabControl.SelectedIndex == 2  )
            {
                softWareMainWindow.Width = 1250;
                softWareMainWindow.Height = 680;

                //GPSItem.Content = new Qitas.SerialBasic();



            }
            else if (functionTabControl.SelectedIndex == 3  )
            {
                softWareMainWindow.Width = 1250;
                softWareMainWindow.Height = 680;

                //FourmItem.Content = new Qitas.GPSMap();



            }
            else
            {
                softWareMainWindow.Width = 800;
                softWareMainWindow.Height = 600;
            }
        }

        private void Fourm_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void SerialBasic_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
