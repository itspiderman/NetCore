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
//user namespace
using WpfApp.com.service;


namespace WpfApp.WpfWindows
{
    /// <summary>
    /// Logon.xaml 的交互逻辑
    /// </summary>
    public partial class WindowLogon : Window
    {
        public WindowLogon()
        {
            InitializeComponent();
        }      

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            String sName = tbName.Text;
            String sPassword = tbPassword.Password;
            Login lg = new Login();
            int iLoginRe = lg.chklogin(sName,sPassword);
            if (iLoginRe > 0)
            {
                MessageBox.Show("Login Successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("User name or password is wrong!");
            }

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
