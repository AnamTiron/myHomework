using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
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

        //private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    Thread.Sleep(2000);
        //}

        //create thread
        //private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    Thread t = new Thread(() =>
        //        {
        //            Thread.Sleep(2000);
        //        });
        //}

        //task example
        //private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    await Task.Run(() => Thread.Sleep(2000));

        //    LoginButton.Content = "Login Successfull!";//Continuation is executed on the calling context
        //}

        //async/await throw exception
        //private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        await LoginAsync();
        //    }
        //    catch (Exception)
        //    {
        //        LoginButton.Content = "Login Failed";
        //    }
        //}

        //private async Task LoginAsync()
        //{
        //    throw new UnauthorizedAccessException();

        //    try
        //    {
        //        var result = await Task.Run(() =>
        //        {
        //            Thread.Sleep(2000);
        //            return "Login Successfull!";
        //        });

        //        LoginButton.Content = result;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                LoginButton.Content = await LoginAsync();
            }
            catch (Exception)
            {
                LoginButton.Content = "Internal Error!";
            }
        }

        private async Task<string> LoginAsync()
        {
            try
            {
                var result = await Task.Run(() =>
                {
                    throw new UnauthorizedAccessException();

                    Thread.Sleep(2000);
                    return "Login Successfull!";
                });

                return result;
            }
            catch (Exception)
            {
                return "Login Failed";
            }
        }

    }
}
