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
using Microsoft.Phone.Controls;
using System.Windows.Controls.Primitives;


namespace PopUpDemo
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ShowPopUpButton_Click(object sender, RoutedEventArgs e)
        {
            Popup screen = new Popup();
            //THis is out control
            FullNameScreen control = new FullNameScreen();

            //adding custom control to the popup
            screen.Child = control;
            screen.VerticalOffset = 100;
            screen.HorizontalOffset = 100;

            //adding event handler to the button on FullNameScreen Ok Button
            //through anonymous method
            control.OkButton.Click += delegate(object s, RoutedEventArgs rea)
            {
                if (control.FirstNameTextBox.Text != "" && control.LastNameTextBox.Text != "")
                {
                    FullNameTextBox.Text = control.FirstNameTextBox.Text + " " + control.LastNameTextBox.Text;
                    screen.IsOpen = false;
                }
                else
                {
                    MessageBox.Show("ERROR: Enter values!");
                }
            };
            control.CancelButton.Click += delegate(object s, RoutedEventArgs rea)
            {
                screen.IsOpen = false;
            };
            screen.IsOpen = true;
        }
    }
}