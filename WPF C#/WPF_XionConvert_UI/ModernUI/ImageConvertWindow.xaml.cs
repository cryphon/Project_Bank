﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModernUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ImageConvertWindow : Window
    {
        public ImageConvertWindow()
        {
            InitializeComponent();
        }

        private void btnQuitImage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnQuit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtHomeButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Close();
            m.Show();   
        }
    }
}
