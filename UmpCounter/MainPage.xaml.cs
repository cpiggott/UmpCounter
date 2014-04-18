using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using UmpCounter.Resources;

namespace UmpCounter
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        int balls = 0;
        int strikes = 0;
        int outs = 0;
        int fouls = 0;

        private void ballsDec_Click(object sender, RoutedEventArgs e)
        {
            if (balls > 0)
            {
                balls--;
                ballsText.Text = balls.ToString();
            }
        }

        private void ballsInc_Click(object sender, RoutedEventArgs e)
        {
            if (balls < 4)
            {
                balls++;
                ballsText.Text = balls.ToString();
            }

            if (balls == 4)
            {
                MessageBox.Show("Batter Walks");
                Reset();
            }
        }

        private void strikeDec_Click(object sender, RoutedEventArgs e)
        {
            if (strikes > 0)
            {
                strikes--;
                strikeText.Text = strikes.ToString();
            }
        }

        private void strikeInc_Click(object sender, RoutedEventArgs e)
        {
            if (strikes < 3)
            {
                strikes++;
                strikeText.Text = strikes.ToString();
            }
            if (strikes == 3)
            {
                MessageBox.Show("Batter is out!");
                Reset();
                outs++;
                outsText.Text = outs.ToString();
                if (outs == 3)
                {
                    MessageBox.Show("Inning is over");
                    outs = 0;
                    outsText.Text = outs.ToString();
                }
            }
        }

        private void outDec_Click(object sender, RoutedEventArgs e)
        {
            if (outs > 0)
            {
                outs--;
                outsText.Text = outs.ToString();
            }
        }

        private void outInc_Click(object sender, RoutedEventArgs e)
        {
            if (outs < 3)
            {
                outs++;
                outsText.Text = outs.ToString();
            }
            if (outs == 3)
            {
                MessageBox.Show("Inning over");
                Reset();
                outs = 0;
                outsText.Text = outs.ToString();
            }
        }


        private void Reset()
        {
            balls = 0;
            ballsText.Text = balls.ToString();
            strikes = 0;
            strikeText.Text = strikes.ToString();
        }

        private void nav_Click(object sender, RoutedEventArgs e)
        {
            Uri pageTwo = new Uri("/SecondPage.xaml", UriKind.RelativeOrAbsolute);
            NavigationService.Navigate(pageTwo);
        }
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}