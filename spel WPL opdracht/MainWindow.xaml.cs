using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace spel_WPL_opdracht
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        int cookie =0;
        int AutoClicker = 0;
        int OmaClicker = 0;
        int MineClicker = 0;
        int FarmClicker = 0;
        int _ticks = 0;

        const int AutoClickerPrijs = 15;
        const int Oma = 100;
        const int Farm = 1100;
        const int Mine = 12000;

        float cookieAuto;
        int omaAuto;
        float som;



        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer wekker = new DispatcherTimer();
            wekker.Tick += new EventHandler(DispatcherTimer_Tick);
            wekker.Interval = new TimeSpan(0, 0, 1);
                                                     
            wekker.Start();


        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            if(AutoClicker > 0 || Oma > 0)
            {
                cookieAuto = 0.1f * AutoClicker;
                omaAuto = 1 * OmaClicker;
                som = cookieAuto + omaAuto;
                AantalCookiesPerSec.Content = "Aantal cookies per seconde: " + som;
            }

            if(AutoClicker >= 1)
            {
                for(int i = 0; i <=1; i+=100)
                {
                    cookie++;
                    LabelScore.Content = cookie;
                }
            }   

            

            if (cookie >= AutoClickerPrijs)
            {
                BtnAutoClicker.IsEnabled = true;   
            }

            if (cookie >= Oma)
            {
                BtnOma.IsEnabled = true;
            }
            if (cookie >= Farm)
            {
                BtnFarm.IsEnabled = true;
            }
            if (cookie >= Mine)
            {
                BtnMine.IsEnabled = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            cookie = _ticks;
 
        }

        private void AfbCookie_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AfbCookie.Width = 180;
            AfbCookie.Height = 280;
        }
        private void AfbCookie_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            cookie ++;
            LabelScore.Content = cookie;

            AfbCookie.Width = 200;
            AfbCookie.Height = 300;

        }
        private void AfbCookie_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
      

        private void BtnAutoClicker_Click_1(object sender, MouseButtonEventArgs e)
        {
           
                
        }

        private void AfbCookie_MouseLeave(object sender, MouseEventArgs e)
        {

        }

   
        private void BtnOma_Click(object sender, RoutedEventArgs e)
        {
            if
               (cookie >= Oma)

            {

                cookie = cookie - Oma;
                LabelScore.Content = cookie;
                LabelOmaPrijs.Content = "Oma gekocht";

                

                OmaClicker++;
                LabelAantalOmaGekocht.Content = OmaClicker;

            }
        }
        private void BtnFarm_Click(object sender, RoutedEventArgs e)
        {
            if
               (cookie >= Farm)

            {

                cookie = cookie - Farm;
                LabelScore.Content = cookie;
                LabelFarmPrijs.Content = "Farm gekocht";

                

                FarmClicker++;
                LabelAantalFarmGekocht.Content = OmaClicker;

            }
        }
        private void BtnMine_Click(object sender, RoutedEventArgs e)
        {
            if
                (cookie >= Mine)

            {
    
                 cookie = cookie - Mine;
                 LabelScore.Content = cookie;
                 LabelMinePrijs.Content = "Mine gekocht";
    
                 MineClicker++;
                 LabelAantalMijnGekocht.Content = OmaClicker;
    
                }
        }

        private void BtnAutoClicker_Click_1(object sender, RoutedEventArgs e)
        {
            if
               (cookie >= AutoClickerPrijs)

            {
               
                cookie = cookie - AutoClickerPrijs;
                LabelScore.Content = cookie;
                LabelAutoClicker.Content = "AutoClicker gekocht";

               

                AutoClicker++;
                LabelAantalAClickerBuy.Content = AutoClicker;

            }
        }

        private void BtnFactory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}