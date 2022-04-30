/*
 * Project: Survey Assignment 7 
 * Author: Kaylie Howard
 * Description: A GUI that takes user entered text and allows the user to change its attributes to make it look like a custom text-logo 
*/
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TextLogoGenerator
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void ComboBox_DropDownClosed(object sender, object e)
        {
            string s = (string)(((ComboBox)sender).SelectedItem);
            outputText.FontFamily = new FontFamily(s);


        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            int value = (int)(e.NewValue);
            if (outputText != null)
            {
                outputText.FontSize = value;
            }

        }

        private void ColorPicker_TextColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            Windows.UI.Color c = args.NewColor;
            SolidColorBrush brush = new SolidColorBrush(c);
            outputText.Foreground = brush;
        }

        private void ColorPicker_BackgroundColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            Windows.UI.Color c = args.NewColor;
            SolidColorBrush brush = new SolidColorBrush(c);
            outputText.Background = brush;
            borderBox.Background = brush;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char name = (char)((Button)sender).Name[0];

            switch (name)
            {
                case 'a':
                    outputText.HorizontalAlignment = HorizontalAlignment.Left;
                    outputText.VerticalAlignment = VerticalAlignment.Top;
                    break;
                case 'b':
                    outputText.HorizontalAlignment = HorizontalAlignment.Center;
                    outputText.VerticalAlignment = VerticalAlignment.Top;
                    break;
                case 'c':
                    outputText.HorizontalAlignment = HorizontalAlignment.Right;
                    outputText.VerticalAlignment = VerticalAlignment.Top;
                    break;
                case 'd':
                    outputText.HorizontalAlignment = HorizontalAlignment.Left;
                    outputText.VerticalAlignment = VerticalAlignment.Center;
                    break;
                case 'e':
                    outputText.HorizontalAlignment = HorizontalAlignment.Center;
                    outputText.VerticalAlignment = VerticalAlignment.Center;
                    break;
                case 'f':
                    outputText.HorizontalAlignment = HorizontalAlignment.Right;
                    outputText.VerticalAlignment = VerticalAlignment.Center;
                    break;
                case 'g':
                    outputText.HorizontalAlignment = HorizontalAlignment.Left;
                    outputText.VerticalAlignment = VerticalAlignment.Bottom;
                    break;
                case 'h':
                    outputText.HorizontalAlignment = HorizontalAlignment.Center;
                    outputText.VerticalAlignment = VerticalAlignment.Bottom;
                    break;
                case 'i':
                    outputText.HorizontalAlignment = HorizontalAlignment.Right;
                    outputText.VerticalAlignment = VerticalAlignment.Bottom;
                    break;
            }
        }

        private void RadioButtons_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb)
            {
                string size = rb.Name;
                switch (size)
                {
                    case "None":
                        borderBox.BorderThickness = new Thickness(0, 0, 0, 0);
                        break;
                    case "Small":
                        borderBox.BorderThickness = new Thickness(2, 2, 2, 2);
                        break;
                    case "Medium":
                        borderBox.BorderThickness = new Thickness(6, 6, 6, 6);
                        break;
                    case "Large":
                        borderBox.BorderThickness = new Thickness(10, 10, 10, 10);
                        break;
                }
            }
        }
    }
}
