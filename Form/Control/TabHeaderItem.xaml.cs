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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Form.Control
{
    /// <summary>
    /// TabHeaderItem.xaml 的交互逻辑
    /// </summary>
    public partial class TabHeaderItem : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsSelect { get; set; } = false;
        public System.Windows.Controls.Page Page { get; set; }
        public string Text { get; set; }
        public TabHeaderItem()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
