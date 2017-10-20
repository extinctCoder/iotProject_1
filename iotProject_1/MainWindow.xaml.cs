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

namespace iotProject_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Led_1_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_1_onn_btn.IsEnabled = false;
            this.led_1_off_btn.IsEnabled = true;
            MainWindow.setConsoleTXT("Led_1_onn_btn_OnClick");
            dbHandler.ledStateChanger(1,1);
        }

        private void Led_1_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_1_onn_btn.IsEnabled = true;
            this.led_1_off_btn.IsEnabled = false;
            MainWindow.setConsoleTXT("Led_1_off_btn_OnClick");
            dbHandler.ledStateChanger(1,0);
        }

        private void Led_2_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_2_onn_btn.IsEnabled = false;
            this.led_2_off_btn.IsEnabled = true;
            MainWindow.setConsoleTXT("Led_2_onn_btn_OnClick");
            dbHandler.ledStateChanger(2,1);
        }

        private void Led_2_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_2_onn_btn.IsEnabled = true;
            this.led_2_off_btn.IsEnabled = false;
            MainWindow.setConsoleTXT("Led_2_off_btn_OnClick");
            dbHandler.ledStateChanger(2,0);
        }

        private void Led_3_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_3_onn_btn.IsEnabled = false;
            this.led_3_off_btn.IsEnabled = true;
            MainWindow.setConsoleTXT("Led_3_onn_btn_OnClick");
            dbHandler.ledStateChanger(3,1);
        }

        private void Led_3_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_3_onn_btn.IsEnabled = true;
            this.led_3_off_btn.IsEnabled = false;
            MainWindow.setConsoleTXT("Led_3_off_btn_OnClick");
            dbHandler.ledStateChanger(3,0);
        }

        private void Led_4_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_4_onn_btn.IsEnabled = false;
            this.led_4_off_btn.IsEnabled = true;
            MainWindow.setConsoleTXT("Led_4_onn_btn_OnClick");
            dbHandler.ledStateChanger(4,1);
        }

        private void Led_4_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_4_onn_btn.IsEnabled = true;
            this.led_4_off_btn.IsEnabled = false;
            MainWindow.setConsoleTXT("Led_4_off_btn_OnClick");
            dbHandler.ledStateChanger(4,0);
        }

        private void Led_5_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_5_onn_btn.IsEnabled = false;
            this.led_5_off_btn.IsEnabled = true;
            MainWindow.setConsoleTXT("Led_5_onn_btn_OnClick");
            dbHandler.ledStateChanger(5,1);
        }

        private void Led_5_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_5_onn_btn.IsEnabled = true;
            this.led_5_off_btn.IsEnabled = false;
            MainWindow.setConsoleTXT("Led_5_off_btn_OnClick");
            dbHandler.ledStateChanger(5,0);
        }

        private void Led_6_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_6_onn_btn.IsEnabled = false;
            this.led_6_off_btn.IsEnabled = true;
            MainWindow.setConsoleTXT("Led_6_onn_btn_OnClick");
            dbHandler.ledStateChanger(6,1);
        }

        private void Led_6_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_6_onn_btn.IsEnabled = true;
            this.led_6_off_btn.IsEnabled = false;
            MainWindow.setConsoleTXT("Led_6_off_btn_OnClick");
            dbHandler.ledStateChanger(6,0);
        }

        public static void setConsoleTXT(String txtConsole)
        {
            using (MainWindow currentMainWindow = Application.Current.MainWindow as MainWindow)
            {
                currentMainWindow.console_txt.Text = currentMainWindow.console_txt.Text + "CONTROL PANEL STATUS : " +
                                                     txtConsole + "\n";
                currentMainWindow.scrl_br.ScrollToEnd();
            }
        }

        public void Dispose()
        {
        }
    }
}
