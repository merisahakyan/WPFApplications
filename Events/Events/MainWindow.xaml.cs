using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myellipse.MouseDown += MouseDownHandler;
            myellipse.MouseUp += MouseUpHandler;
            myellipse.MouseMove += MouseMoveHandler;
            mybutton.Click += ButtonClickHandler;

        }
        void MouseDownHandler(object sender, EventArgs e)
        {
            Debug.WriteLine("MouseDown");
        }
        void MouseUpHandler(object sender, EventArgs e)
        {
            Debug.WriteLine("MouseUp");
        }
        void ButtonClickHandler(object sender, EventArgs e)
        {
            Debug.WriteLine("Button Click");
        }
        bool t = true;
        void MouseMoveHandler(object sender, EventArgs e)
        {
            if (myellipse.Width > 3)
                myellipse.Width = myellipse.Width - 3;

        }

    }
}
