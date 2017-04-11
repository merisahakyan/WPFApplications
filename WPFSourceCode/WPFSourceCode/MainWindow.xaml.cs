using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

namespace WPFSourceCode
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            getbutton.IsEnabled = false;
            using (var client = new HttpClient())
            {
                try
                {
                    var url = urltextbox.Text;
                    sourcetextbox.Text = await client.GetStringAsync(url);
                }
                catch
                {
                    sourcetextbox.Text = "Oops! Something went wrong.";
                }
                finally
                {
                    getbutton.IsEnabled = true;
                }
            }
        }
    }
}
