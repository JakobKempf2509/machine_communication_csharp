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

namespace machine_communication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void my_bt_stream_Click(object sender, RoutedEventArgs e)
        {
            if (my_eingabe_ip != null)
            {
                string ip_eingabe = my_eingabe_ip.Text;
                my_tb_test.Text = "Die von Ihnen eingegebene IP-Adresse lautet:\n" + ip_eingabe;

            }
        }
    }
}
