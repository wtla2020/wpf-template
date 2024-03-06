using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Form.Control
{
    /// <summary>
    /// Card.xaml 的交互逻辑
    /// </summary>
    public partial class Card : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ImageSource Source { get; set; }
        public string Text { get; set; }
        public Card()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                To = 120,
                Duration = TimeSpan.FromSeconds(0.2)
            };
            brdBack.BeginAnimation(HeightProperty, animation);
            e.Handled = true;
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                To = 0,
                Duration = TimeSpan.FromSeconds(0.2)
            };
            brdBack.BeginAnimation(HeightProperty, animation);
            e.Handled = true;
        }
    }
}
