using System.Windows;
using System.Windows.Input;
using paletteflow.ViewModels;

namespace paletteflow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal) {
                WindowState = WindowState.Maximized;
                MaximizeText.Text = "🗗︎";
            }
            else
            {
                WindowState = WindowState.Normal;
                MaximizeText.Text = "🗖";
            }
                

        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}