using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Photo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }
        class Boy
        {
            internal void Action(object sender, ElapsedEventArgs e)
            {
                MessageBox.Show("jump");

            }
        }
        class Girl
        {
            internal void Action(object sender, ElapsedEventArgs e)
            {
                MessageBox.Show("dance");
            }
        }
        private void buttonClicked(object sender, RoutedEventArgs e)
        {
           
          
            Timer timer = new Timer();
            timer.Interval = 1000;
            Boy boy = new Boy();
            Girl girl = new Girl();
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
        }

        private void Tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}