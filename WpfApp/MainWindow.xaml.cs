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


namespace WpfApp
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

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            WindowThd wt = new WpfApp.WindowThd();
            wt.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            WindowCanvas wc = new WindowCanvas();
            wc.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            WindowDock wd = new WindowDock();
            wd.ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            WpfWindows.WindowViewBox wv = new WpfWindows.WindowViewBox();
            wv.ShowDialog();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            WpfWindows.WindowBindData wd = new WpfWindows.WindowBindData();
            wd.ShowDialog();
        }
    }
}
