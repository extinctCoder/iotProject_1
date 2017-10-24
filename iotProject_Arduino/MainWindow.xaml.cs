namespace iotProject_Arduino
{
    using System;
    using System.Threading;
    using System.Windows;
    using System.Windows.Media;

    using Arduino4Net.Components.Leds;
    using Arduino4Net.Models;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        private Arduino arduino;

        private bool led_1_state = false;

        private bool led_2_state = false;

        private bool led_3_state = false;

        private bool led_4_state = false;

        private bool led_5_state = false;

        private bool led_6_state = false;

        private Led ledPin_1;

        private Led ledPin_2;

        private Led ledPin_3;

        private Led ledPin_4;

        private Led ledPin_5;

        private Led ledPin_6;

        private bool temp_btn_led_1_state = false;

        private bool temp_btn_led_2_state = false;

        private bool temp_btn_led_3_state = false;

        private bool temp_btn_led_4_state = false;

        private bool temp_btn_led_5_state = false;

        private bool temp_btn_led_6_state = false;

        public MainWindow()
        {
            this.InitializeComponent();
            this.arduino = new Arduino();
            this.ledPin_1 = new Led(this.arduino, 6);
            this.ledPin_2 = new Led(this.arduino, 7);
            this.ledPin_3 = new Led(this.arduino, 8);
            this.ledPin_4 = new Led(this.arduino, 9);
            this.ledPin_5 = new Led(this.arduino, 10);
            this.ledPin_6 = new Led(this.arduino, 11);
            Thread initThread = new Thread(new ThreadStart(this.updateLedState));
            initThread.IsBackground = true;
            initThread.Start();
        }

        public static void setConsoleTXT(string txtConsole)
        {
            using (MainWindow currentMainWindow = Application.Current.MainWindow as MainWindow)
            {
                lock (currentMainWindow.console_txt)
                {
                    currentMainWindow.console_txt.Text = currentMainWindow.console_txt.Text
                                                         + "ARDUINO CONTROL PANEL STATUS : " + txtConsole + "\n";
                    currentMainWindow.scrl_br.ScrollToEnd();
                }
            }
        }

        public void Dispose()
        {
        }
    }

    public partial class MainWindow
    {
        public void buttonStateChanger()
        {
            if (this.led_1_state != this.temp_btn_led_1_state)
            {
                this.led_1_onn_btn.Background = this.led_1_state ? Brushes.Green : Brushes.White;
                this.led_1_off_btn.Background = (!this.led_1_state) ? Brushes.Red : Brushes.White;
                setConsoleTXT(
                    this.led_1_state ? "led number one turned onn from cloud" : "led number one turned off from cloud");
                this.arduinoUploder(1, this.led_1_state ? 1 : 0);
                this.temp_btn_led_1_state = this.led_1_state;
            }

            if (this.led_2_state != this.temp_btn_led_2_state)
            {
                this.led_2_onn_btn.Background = this.led_2_state ? Brushes.Green : Brushes.White;
                this.led_2_off_btn.Background = (!this.led_2_state) ? Brushes.Red : Brushes.White;
                setConsoleTXT(
                    this.led_2_state ? "led number two turned onn from cloud" : "led number two turned off from cloud");
                this.arduinoUploder(2, this.led_2_state ? 1 : 0);
                this.temp_btn_led_2_state = this.led_2_state;
            }

            if (this.led_3_state != this.temp_btn_led_3_state)
            {
                this.led_3_onn_btn.Background = this.led_3_state ? Brushes.Green : Brushes.White;
                this.led_3_off_btn.Background = (!this.led_3_state) ? Brushes.Red : Brushes.White;
                setConsoleTXT(
                    this.led_3_state
                        ? "led number three turned onn from cloud"
                        : "led number three turned off from cloud");
                this.arduinoUploder(3, this.led_3_state ? 1 : 0);
                this.temp_btn_led_3_state = this.led_3_state;
            }

            if (this.led_4_state != this.temp_btn_led_4_state)
            {
                this.led_4_onn_btn.Background = this.led_4_state ? Brushes.Green : Brushes.White;
                this.led_4_off_btn.Background = (!this.led_4_state) ? Brushes.Red : Brushes.White;
                setConsoleTXT(
                    this.led_4_state
                        ? "led number four turned onn from cloud"
                        : "led number four turned off from cloud");
                this.arduinoUploder(4, this.led_4_state ? 1 : 0);
                this.temp_btn_led_4_state = this.led_4_state;
            }

            if (this.led_5_state != this.temp_btn_led_5_state)
            {
                this.led_5_onn_btn.Background = this.led_5_state ? Brushes.Green : Brushes.White;
                this.led_5_off_btn.Background = (!this.led_5_state) ? Brushes.Red : Brushes.White;
                setConsoleTXT(
                    this.led_5_state
                        ? "led number five turned onn from cloud"
                        : "led number five turned off from cloud");
                this.arduinoUploder(5, this.led_5_state ? 1 : 0);
                this.temp_btn_led_5_state = this.led_5_state;
            }

            if (this.led_6_state != this.temp_btn_led_6_state)
            {
                this.led_6_onn_btn.Background = this.led_6_state ? Brushes.Green : Brushes.White;
                this.led_6_off_btn.Background = (!this.led_6_state) ? Brushes.Red : Brushes.White;
                setConsoleTXT(
                    this.led_6_state ? "led number six turned onn from cloud" : "led number six turned off from cloud");
                this.arduinoUploder(6, this.led_6_state ? 1 : 0);
                this.temp_btn_led_6_state = this.led_6_state;
            }
        }

        void setAllButtonDefult()
        {
            this.led_1_state = false;
            this.led_2_state = false;
            this.led_3_state = false;
            this.led_4_state = false;
            this.led_5_state = false;
            this.led_6_state = false;
            this.led_1_onn_btn.Background = Brushes.White;
            this.led_1_off_btn.Background = Brushes.White;
            this.led_2_onn_btn.Background = Brushes.White;
            this.led_2_off_btn.Background = Brushes.White;
            this.led_3_onn_btn.Background = Brushes.White;
            this.led_3_off_btn.Background = Brushes.White;
            this.led_4_onn_btn.Background = Brushes.White;
            this.led_4_off_btn.Background = Brushes.White;
            this.led_5_onn_btn.Background = Brushes.White;
            this.led_5_off_btn.Background = Brushes.White;
            this.led_6_onn_btn.Background = Brushes.White;
            this.led_6_off_btn.Background = Brushes.White;
        }
    }

    public partial class MainWindow
    {
        private void arduinoUploder(int portid, int status)
        {
            if (portid == 1 && status == 0)
            {
                this.ledPin_1.Off();
            }
            else if (portid == 1 && status == 1)
            {
                this.ledPin_1.On();
            }
            else if (portid == 2 && status == 0)
            {
                this.ledPin_2.Off();
            }
            else if (portid == 2 && status == 1)
            {
                this.ledPin_2.On();
            }
            else if (portid == 3 && status == 0)
            {
                this.ledPin_3.Off();
            }
            else if (portid == 3 && status == 1)
            {
                this.ledPin_3.On();
            }
            else if (portid == 4 && status == 0)
            {
                this.ledPin_4.Off();
            }
            else if (portid == 4 && status == 1)
            {
                this.ledPin_4.On();
            }
            else if (portid == 5 && status == 0)
            {
                this.ledPin_5.Off();
            }
            else if (portid == 5 && status == 1)
            {
                this.ledPin_5.On();
            }
            else if (portid == 6 && status == 0)
            {
                this.ledPin_6.Off();
            }
            else if (portid == 6 && status == 1)
            {
                this.ledPin_6.On();
            }
        }

        private void updateLedState()
        {
            while (true)
            {
                this.block_grid.Dispatcher.Invoke(
                    (Action)(() =>
                        {
                            this.led_1_state = dbHandler.getLedState(1);
                            this.led_2_state = dbHandler.getLedState(2);
                            this.led_3_state = dbHandler.getLedState(3);
                            this.led_4_state = dbHandler.getLedState(4);
                            this.led_5_state = dbHandler.getLedState(5);
                            this.led_6_state = dbHandler.getLedState(6);
                            this.buttonStateChanger();
                        }));
            }
        }
    }
}