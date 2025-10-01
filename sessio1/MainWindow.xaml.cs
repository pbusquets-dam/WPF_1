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

namespace sessio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid elmeugrid = new Grid();
            this.Content = elmeugrid;
            Button btn = new Button();
            //elmeugrid.Children.Add(btn);
            WrapPanel elmeuWrapPanel = new WrapPanel();

            TextBlock txt = new TextBlock();
            txt.Text = "hola ";
            elmeuWrapPanel.Children.Add(txt);
            txt.Foreground = Brushes.AliceBlue;


            TextBlock txt2 = new TextBlock();
            txt2.Text = "adeu ";
            elmeuWrapPanel.Children.Add(txt2);
            txt2.Foreground = Brushes.HotPink;

            TextBlock txt3 = new TextBlock();
            txt3.Text = "andreu ";
            elmeuWrapPanel.Children.Add(txt3);
            txt3.Foreground = Brushes.Gold;

            btn.Height = 100;
            btn.Width = 200;
            btn.Content = elmeuWrapPanel;
            elmeugrid.Children.Add(btn);
        }


    }
}
