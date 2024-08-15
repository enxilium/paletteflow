using System.Windows;

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

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            // Go to home screen
        }

        private void EnterButton_DragEnter(object sender, DragEventArgs e)
        {
            EnterButton.FontSize = 13;
        }

        private void EnterButton_DragLeave(object sender, DragEventArgs e)
        {
            EnterButton.FontSize = 12;  
        }
    }
}