using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace UmpCounter
{
    public partial class SecondPage : PhoneApplicationPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void buttonPage2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}