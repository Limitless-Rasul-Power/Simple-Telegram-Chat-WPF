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

namespace WpfApp_Simple_Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtBxMessage.Focus();
        }

        private void BtnSendImage_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".jpg",
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };

            var result = openFileDialog.ShowDialog();

            if (result == true)
            {
                ScrollViewer scrollViewer = CreateScrollViewer();

                Grid grid = CreateGridWithOneTextBlock();

                Image image = new Image
                {
                    Width = 200,
                    Height = 100,
                    Source = new BitmapImage(new Uri(openFileDialog.FileName)),
                    Margin = new Thickness(ScrlVwrFirst.ActualWidth - 250, 0, 0, 0)
                };

                grid.Children.Add(image);

                scrollViewer.Content = grid;

                LstBxMessages.Items.Add(scrollViewer);
                LstBxMessages.ScrollIntoView(LstBxMessages.Items[LstBxMessages.Items.Count - 1]);

            }

            TxtBxMessage.Focus();
        }

        private void BtnSendText_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtBxMessage.Text))
            {
                ScrollViewer scrollViewer = CreateScrollViewer();

                Grid grid = CreateGridWithOneTextBlock();

                var textBlockSecond = new TextBlock
                {
                    TextWrapping = TextWrapping.Wrap,
                    MaxWidth = 210,
                    Margin = new Thickness(ScrlVwrFirst.ActualWidth - 250, 0, 0, 0),
                    Text = $"{TxtBxMessage.Text}"
                };

                grid.Children.Add(textBlockSecond);

                scrollViewer.Content = grid;

                TxtBxMessage.Text = default;

                LstBxMessages.Items.Add(scrollViewer);
                LstBxMessages.ScrollIntoView(LstBxMessages.Items[LstBxMessages.Items.Count - 1]);
            }

            TxtBxMessage.Focus();
        }       

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            List<ScrollViewer> scrollViewers = CreateNewScrollViewersWhenWindowSizeChanges();

            LstBxMessages.Items.Clear();

            scrollViewers.ForEach(sv => LstBxMessages.Items.Add(sv));

            if (LstBxMessages.Items.Count != 0)
            {
                LstBxMessages.ScrollIntoView(LstBxMessages.Items[LstBxMessages.Items.Count - 1]);
            }
        }


        #region Helpers

        private ScrollViewer CreateScrollViewer()
        {
            return new ScrollViewer
            {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                Margin = new Thickness(0, 10, 0, 0),
                HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled
            };
        }

        private Grid CreateGridWithOneTextBlock()
        {
            Grid grid = new Grid();

            TextBlock textBlockFirst = new TextBlock
            {
                TextWrapping = TextWrapping.Wrap,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#31572c")),
                FontWeight = FontWeights.SemiBold,
                Text = $"{DateTime.Now.ToShortTimeString()}"
            };

            grid.Children.Add(textBlockFirst);

            return grid;
        }

        private List<ScrollViewer> CreateNewScrollViewersWhenWindowSizeChanges()
        {
            List<ScrollViewer> scrollViewers = new List<ScrollViewer>();

            const int messageIndex = 1;

            for (int i = 0; i < LstBxMessages.Items.Count; i++)
            {
                scrollViewers.Add(LstBxMessages.Items[i] as ScrollViewer);
                Grid grid = scrollViewers[i].Content as Grid;
                FrameworkElement element = grid.Children[messageIndex] as FrameworkElement;
                element.Margin = new Thickness(ScrlVwrFirst.ActualWidth - 250, 0, 0, 0);
            }

            return scrollViewers;
        }

        #endregion


    }
}
