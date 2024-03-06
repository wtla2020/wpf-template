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

namespace Form.Control
{
    /// <summary>
    /// Menu.xaml 的交互逻辑
    /// </summary>
    public partial class Menu : UserControl
    {
        // 定义一个事件委托
        public delegate void MenuSelectEventHandler(MenuItem menu,EventArgs eventArgs);

        // 定义事件
        public event MenuSelectEventHandler MenuSelectEvent;
        public Menu()
        {
            InitializeComponent();
        }

        public void Select(MenuItem tab)
        {
            foreach (MenuItem btn in this.stk.Children)
            {
                btn.IsSelect = false;
            }
            if(tab != null)
            {
                tab.IsSelect = true;
            }
        }
        private void Btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach(MenuItem btn in this.stk.Children)
            {
                btn.IsSelect = false;
            }
            var selectBtn = sender as MenuItem;
            selectBtn.IsSelect = true;
            MenuSelectEvent?.Invoke(selectBtn, EventArgs.Empty);
        }

        public void Add(MenuItem menuItem)
        {
            menuItem.MouseDown += Btn_MouseDown;
            this.stk.Children.Add(menuItem);
        }
    }
}
