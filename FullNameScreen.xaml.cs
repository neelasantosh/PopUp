using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PopUpDemo
{
    public partial class FullNameScreen : UserControl
    {
        public FullNameScreen()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FirstNameTextBox.Text = "";
        }
    }
}
