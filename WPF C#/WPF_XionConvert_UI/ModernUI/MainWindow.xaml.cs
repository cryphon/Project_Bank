using System;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetUser();
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

        private void GetUser()
        {
            lblUser.Text = Environment.UserName;
        }

        private void btnImages_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow("images");
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ShowWindow("images");
        }

        void ShowWindow(string windowname)
        {
            
            switch (windowname)
            {
                case "images":
                    ImageConvertWindow w = new ImageConvertWindow();
                    w.Show();
                    break;
            }
            this.Close();
        }
    }
}
