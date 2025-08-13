using System.Windows;

namespace Machine.Views
{
    /// <summary>
    /// Logica di interazione per ListDialog.xaml
    /// </summary>
    public partial class ListDialog : Window
    {
        public ListDialog()
        {
            InitializeComponent();
        }

        private void OnButtonOK(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void OnButtonCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
