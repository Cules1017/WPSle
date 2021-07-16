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

namespace MarginonWPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int k=0;
        int[][] a;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Content != null) return;
            if(k==0)
            {
                btn.Content = "X";
                k = 1;
                
            }
            else
            {
                btn.Content = "O";
                k = 0;
            }
            Win(btn);


        }
        int hang1 = 0;
        int o1 = 0, o2 = 0, o3 = 0, ocheo = 0, ocheo2=0; 
        int hang2 = 0;
        int hang3 = 0;
        int cheo = 0;
        int cheo2 = 0, dem = 0;
        private void Win(Button btn)
        {

            dem++;
             if(btn.Name=="T1")
            {
               
                if(btn.Content.ToString()=="X")
                {
                    hang1++;
                    cheo++;// MessageBox.Show(hang1.ToString());
                }
                else
                {
                    o1++;
                    ocheo++;
                }
            }

            if (btn.Name == "T2")
            {
                if (btn.Content.ToString() == "X")
                {
                    hang1++; //MessageBox.Show(hang1.ToString());
                }
                else
                {
                    o1++;
                }
            }
            if (btn.Name == "T3")
            {
                if (btn.Content.ToString() == "X")
                {
                    cheo2++;
                    hang1++; //MessageBox.Show(hang1.ToString());
                }
                else
                {
                    o1++;
                    ocheo2++;
                }
            }

            if (btn.Name == "G2")
            {
                if (btn.Content.ToString() == "X")
                {
                    hang2++;
                    cheo++;
                    cheo2++;
                }
                else
                {
                    o2++;
                    ocheo++;
                    ocheo2++;
                }
            }

            if (btn.Name == "G1")
            {
                if (btn.Content.ToString() == "X")
                {
                    hang2++;
                }
                else
                {
                    o2++;
                }
            }
            if (btn.Name == "G3")
            {
                if (btn.Content.ToString() == "X")
                {
                    hang2++;
                }
                else
                {
                    o2++;
                }
            }
            if (btn.Name == "D3")
            {
                if (btn.Content.ToString() == "X")
                {
                    hang3++;
                    cheo++;
                }
                else
                {
                    o3++;
                    ocheo++;
                }
            }

            if (btn.Name == "D1")
            {
                if (btn.Content.ToString() == "X")
                {
                    hang3++;
                    cheo2++;
                }
                else
                {
                    o3++;
                    ocheo2++;
                }
            }
            if (btn.Name == "D2")
            {
                
                if (btn.Content.ToString() == "X")
                {
                    hang3++;
                }
                else
                {
                    o3++;
                }
            }
            if (hang1 == 3 || hang2 == 3 || hang3 == 3 || cheo == 3||cheo2==3) { MessageBox.Show("X thắng!!!"); }
            if (o1 == 3 || o2 == 3 || o3 == 3 || ocheo == 3||ocheo2==3) MessageBox.Show("O thắng!!!");
            if (dem == 9) MessageBox.Show("Hòa @@");


        }
    }
}
