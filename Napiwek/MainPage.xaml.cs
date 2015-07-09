using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Napiwek
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DataNapiwek nowynapiwek = new DataNapiwek();
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        public void odznaczenie()
        {
            piecprocent.IsChecked = false;
            dziesiecprocent.IsChecked = false;
            pietnascieprocent.IsChecked = false;
            dwadziesciaprocent.IsChecked = false;
            KwotaNapiwku.Text = KwotaRachuku.Text = "";
        }

        public void obliczanieKwotyiNapiwku()
        { 
}
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void piecprocent_Checked(object sender, RoutedEventArgs e)
        {
            double procent = 0.05;
            WartoscNapiwku.Text = nowynapiwek.obliczprocnet(nowynapiwek.wartoscnapiwku, procent).ToString("0.00");
            KwotaRachuku.Text = nowynapiwek.wartoscnapiwku.ToString("0.00");
            KwotaNapiwku.Text = (nowynapiwek.obliczprocnet(nowynapiwek.wartoscnapiwku, procent) - nowynapiwek.wartoscnapiwku).ToString("0.00");
        }

        public void WartoscNapiwku_LostFocus(object sender, RoutedEventArgs e)
        {
            if (WartoscNapiwku.Text == "")
            {
                WartoscNapiwku.Text = "brak";
                Kwota.Text = "Kwota rachunku:";
                nowynapiwek.wartoscnapiwku = 0;
                odznaczenie();
            }
            else
            {
                Kwota.Text = "Kwota do zapłaty:";
                nowynapiwek.wartoscnapiwku = double.Parse(WartoscNapiwku.Text);
                odznaczenie();
            }
        }

        private void dziesiecprocent_Checked(object sender, RoutedEventArgs e)
        {
            double procent = 0.1;
            WartoscNapiwku.Text = nowynapiwek.obliczprocnet(nowynapiwek.wartoscnapiwku, procent).ToString("0.00");
            KwotaRachuku.Text = nowynapiwek.wartoscnapiwku.ToString("0.00");
            KwotaNapiwku.Text = (nowynapiwek.obliczprocnet(nowynapiwek.wartoscnapiwku, procent) - nowynapiwek.wartoscnapiwku).ToString("0.00");

        }

        private void pietnascieprocent_Checked(object sender, RoutedEventArgs e)
        {
            double procent = 0.15;
            WartoscNapiwku.Text = nowynapiwek.obliczprocnet(nowynapiwek.wartoscnapiwku, procent).ToString("0.00");
            KwotaRachuku.Text = nowynapiwek.wartoscnapiwku.ToString("0.00");
            KwotaNapiwku.Text = (nowynapiwek.obliczprocnet(nowynapiwek.wartoscnapiwku, procent) - nowynapiwek.wartoscnapiwku).ToString("0.00");
        }

        private void dwadziesciaprocent_Checked(object sender, RoutedEventArgs e)
        {
            double procent = 0.2;
            WartoscNapiwku.Text = nowynapiwek.obliczprocnet(nowynapiwek.wartoscnapiwku, procent).ToString("0.00");
            KwotaRachuku.Text = nowynapiwek.wartoscnapiwku.ToString("0.00");
            KwotaNapiwku.Text = (nowynapiwek.obliczprocnet(nowynapiwek.wartoscnapiwku, procent) - nowynapiwek.wartoscnapiwku).ToString("0.00");
        }

        private void WartoscNapiwku_GotFocus(object sender, RoutedEventArgs e)
        {
            WartoscNapiwku.Text = string.Empty;
        }

        private void WartoscNapiwku_KeyUp(object sender, KeyRoutedEventArgs e)
        { //for USA must be . rather then ,
            TextBox txt = (TextBox)sender;
            if (txt.Text.Contains(','))
            {
                txt.Text = txt.Text.Replace(",", "");
                txt.SelectionStart = txt.Text.Length;
            }
        }



    }
}
