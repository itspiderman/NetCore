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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// WindowDock.xaml 的交互逻辑
    /// </summary>
    public partial class WindowDock : Window
    {
        public WindowDock()
        {
            InitializeComponent();
        }

        private void btnAddByCode_Click(object sender, RoutedEventArgs e)
        {
            DockPanel dp = new DockPanel();
            //  dp.LastChildFill = true;
            dp.Width = Double.NaN;    //相当于在XAML中设置Width="Auto"
            dp.Height = Double.NaN;   //相当于在XAML中设置Height="Auto"
            //把dp添加为窗体的子控件
            this.Content = dp;
            //添加Rectangles
            Rectangle rTop = new Rectangle();
            rTop.Fill = new SolidColorBrush(Colors.BlanchedAlmond);
            rTop.Stroke = new SolidColorBrush(Colors.BlanchedAlmond);
            rTop.Height = 30;
            dp.Children.Add(rTop);
            rTop.SetValue(DockPanel.DockProperty, Dock.Top);

            Rectangle rLeft = new Rectangle();
            rLeft.Fill = new SolidColorBrush(Colors.Gray);
            rLeft.Stroke = new SolidColorBrush(Colors.Gray);
            rLeft.HorizontalAlignment = HorizontalAlignment.Left;
            rLeft.Height = 30;
            rLeft.Width = 30;
            dp.Children.Add(rLeft);
            rLeft.SetValue(DockPanel.DockProperty, Dock.Left);

            Rectangle rBottom = new Rectangle();
            rBottom.Fill = new SolidColorBrush(Colors.Red);
            rBottom.VerticalAlignment = VerticalAlignment.Bottom;
            rBottom.Height = 30;
            dp.Children.Add(rBottom);
            rBottom.SetValue(DockPanel.DockProperty, Dock.Bottom);

        }
    }
}
