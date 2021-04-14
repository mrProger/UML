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

namespace MyWPFProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush color;
        //bool colorFlag = true;  
        int colorFlag = 1;

        public MainWindow()
        {
            InitializeComponent();
            Btn1.Click += new RoutedEventHandler(Btn1Click);
            color = this.Background;
        }

        void Btn1Click(object sender, RoutedEventArgs e) 
        {
            switch (colorFlag) {
                case 1: this.Background = Brushes.Bisque; break;
                case 2: this.Background = Brushes.Green; break;
                case 3: this.Background = Brushes.Aqua; break;
                case 4: this.Background = Brushes.Blue; break;
                case 5: this.Background = Brushes.Orange; break;
            }

            if (colorFlag == 5) colorFlag = 1;
            else colorFlag++;

            /*if (colorFlag) this.Background = System.Windows.Media.Brushes.Green;
            else this.Background = color;

            colorFlag = !colorFlag;*/
        }

        void Btn2Click(object sender, RoutedEventArgs e) { Close(); }
    }
}
