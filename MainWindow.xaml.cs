using System.Windows;
using System.Windows.Media;

namespace Unofficial.Yandex.Music
{
    public partial class MainWindow : Window
    {
        private Brush captionGradientBrush, captionBrush;
        public MainWindow()
        {
            InitializeComponent();
            captionGradientBrush = captionGrid.Background;
            captionBrush = contentGrid.Background;
            if (!Properties.Settings.Default.ShowGradient)
                captionGrid.Background = captionBrush;
            contentGrid.Opacity = Properties.Settings.Default.Opacity;
        }
        #region Cool window
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
        public new ImageSource Icon
        {
            get => windowIconBox.Source;
            set => windowIconBox.Source = value;
        }
        #endregion
        #region Main page
        #endregion
        #region Radio page
        #endregion
        #region Podcasts page
        #endregion
        #region Liked tracks page
        #endregion
        #region Liked albums page
        #endregion
        #region Liked playlists page
        #endregion
        #region Liked artists page
        #endregion
        #region Local tracks page
        #endregion
        #region Settings page
        #endregion
        #region YaID page
        #endregion
    }
}