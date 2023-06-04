using MVVM.ViewModel;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace UmbraClient;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        //Scroll
        DispatcherTimer timer = new() { Interval = new TimeSpan(0, 0, 2) };
        timer.Tick += (sender, e) =>
        {
            MainGrid.Height += 10;

            if (ScrollViewer.VerticalOffset == ScrollViewer.ScrollableHeight)
                ScrollViewer.ScrollToEnd();
        };
        timer.Start();
    }

    private protected void Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed) DragMove();
    }

    private protected void Window_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        BorderThickness = (Width == MaxWidth | WindowState == WindowState.Maximized) ? new Thickness(10) : new Thickness(0);
    }

    private protected void WindowButton_Click(object sender, RoutedEventArgs e)
    {
        switch (((Button)sender).Content)
        {
            case "＿":
                WindowState = WindowState.Minimized;
                break;

            case "▭":
                WindowState = (WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
                break;

            case "⨉":
                Close();
                break;
        }
    }

    private protected void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
    {
        ScrollViewer.ScrollToVerticalOffset(ScrollViewer.VerticalOffset - e.Delta / 3);
    }
}