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

namespace WpfTextblock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TL2.Text = TL1.Inlines.ToString();
            TL2.Inlines.Add("Hey bro");
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tb= sender as TextBlock;
            tb.Text = "HELLO";

        }
    }
}
