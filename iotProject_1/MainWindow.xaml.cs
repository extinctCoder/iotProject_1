namespace iotProject_1
{
    using System;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        public static string getIpAddress()
        {
            string tempString = null;
            using (MainWindow currentMainWindow = Application.Current.MainWindow as MainWindow)
            {
                tempString = currentMainWindow.ip_address_txt.Text.ToString();
            }

            return tempString;
        }

        public static string getPassword()
        {
            string tempString = null;
            using (MainWindow currentMainWindow = Application.Current.MainWindow as MainWindow)
            {
                tempString = currentMainWindow.password_txt.Text.ToString();
            }

            return tempString;
        }

        public static string getUid()
        {
            string tempString = null;
            using (MainWindow currentMainWindow = Application.Current.MainWindow as MainWindow)
            {
                tempString = currentMainWindow.uid_txt.Text.ToString();
            }

            return tempString;
        }

        public static void setConsoleTXT(string txtConsole)
        {
            using (MainWindow currentMainWindow = Application.Current.MainWindow as MainWindow)
            {
                currentMainWindow.console_txt.Text =
                    currentMainWindow.console_txt.Text + "CONTROL PANEL STATUS : " + txtConsole + "\n";
                currentMainWindow.scrl_br.ScrollToEnd();
            }
        }

        public void Dispose()
        {
        }

        private void Led_1_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_1_onn_btn.IsEnabled = true;
            this.led_1_off_btn.IsEnabled = false;
            setConsoleTXT("Led_1_off_btn_OnClick");
            dbHandler.ledStateChanger(1, 0);
        }

        private void Led_1_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_1_onn_btn.IsEnabled = false;
            this.led_1_off_btn.IsEnabled = true;
            setConsoleTXT("Led_1_onn_btn_OnClick");
            dbHandler.ledStateChanger(1, 1);
        }

        private void Led_2_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_2_onn_btn.IsEnabled = true;
            this.led_2_off_btn.IsEnabled = false;
            setConsoleTXT("Led_2_off_btn_OnClick");
            dbHandler.ledStateChanger(2, 0);
        }

        private void Led_2_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_2_onn_btn.IsEnabled = false;
            this.led_2_off_btn.IsEnabled = true;
            setConsoleTXT("Led_2_onn_btn_OnClick");
            dbHandler.ledStateChanger(2, 1);
        }

        private void Led_3_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_3_onn_btn.IsEnabled = true;
            this.led_3_off_btn.IsEnabled = false;
            setConsoleTXT("Led_3_off_btn_OnClick");
            dbHandler.ledStateChanger(3, 0);
        }

        private void Led_3_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_3_onn_btn.IsEnabled = false;
            this.led_3_off_btn.IsEnabled = true;
            setConsoleTXT("Led_3_onn_btn_OnClick");
            dbHandler.ledStateChanger(3, 1);
        }

        private void Led_4_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_4_onn_btn.IsEnabled = true;
            this.led_4_off_btn.IsEnabled = false;
            setConsoleTXT("Led_4_off_btn_OnClick");
            dbHandler.ledStateChanger(4, 0);
        }

        private void Led_4_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_4_onn_btn.IsEnabled = false;
            this.led_4_off_btn.IsEnabled = true;
            setConsoleTXT("Led_4_onn_btn_OnClick");
            dbHandler.ledStateChanger(4, 1);
        }

        private void Led_5_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_5_onn_btn.IsEnabled = true;
            this.led_5_off_btn.IsEnabled = false;
            setConsoleTXT("Led_5_off_btn_OnClick");
            dbHandler.ledStateChanger(5, 0);
        }

        private void Led_5_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_5_onn_btn.IsEnabled = false;
            this.led_5_off_btn.IsEnabled = true;
            setConsoleTXT("Led_5_onn_btn_OnClick");
            dbHandler.ledStateChanger(5, 1);
        }

        private void Led_6_off_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_6_onn_btn.IsEnabled = true;
            this.led_6_off_btn.IsEnabled = false;
            setConsoleTXT("Led_6_off_btn_OnClick");
            dbHandler.ledStateChanger(6, 0);
        }

        private void Led_6_onn_btn_OnClick(object sender, RoutedEventArgs e)
        {
            this.led_6_onn_btn.IsEnabled = false;
            this.led_6_off_btn.IsEnabled = true;
            setConsoleTXT("Led_6_onn_btn_OnClick");
            dbHandler.ledStateChanger(6, 1);
        }
    }
}