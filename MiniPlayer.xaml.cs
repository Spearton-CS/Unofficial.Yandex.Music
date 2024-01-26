using System.Windows;

namespace Unofficial.Yandex.Music
{
    public partial class MiniPlayer : Window
    {
        public MiniPlayer()
        {
            throw new NotSupportedException("Now MiniPlayer is not realized");
            InitializeComponent();
        }
        #region Cool window border
        private void windowTitleBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => DragMove();
        private void minimizeWindowButton_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;
        private void maximizeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }
        private void closeWindowButton_Click(object sender, RoutedEventArgs e) => Close();
        public new string Title
        {
            get => windowTitleBlock.Text;
            set => windowTitleBlock.Text = value;
        }
        public new System.Windows.Media.ImageSource Icon
        {
            get => windowIconBox.Source;
            set => windowIconBox.Source = value;
        }
        #endregion
    }
}