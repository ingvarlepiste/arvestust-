using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestustöö
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        int counter = 1;

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            string kasutajanimi = "user";
            string parool = "SecretPassword";

            if (counter <= 3)
            {


                if (userBox.Text == kasutajanimi && passwordBox.Password == parool) 
                {
                    this.Frame.Navigate(typeof(Content1));


                }
                else
                {
                    resultBlock.Text = "Sisselogimine ebaõnnestus. Rohkem katseid sisenemiseni";
                    counter++;

                }
            }
            else
            {
                resultBlock.Text = "Sisselogimine ebaõnnestus. Rohkem katseid sisenemiseks ei ole.";
                button1.IsEnabled = false;


            }
        }

    }

}

