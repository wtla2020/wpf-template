using Dao.Model;
using Dapper;
using Form.Config;
using Form.Page.Dialog;
using HandyControl.Controls;
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

namespace Form.Page.Home
{
    /// <summary>
    /// HomeView.xaml 的交互逻辑
    /// </summary>
    public partial class HomeView : System.Windows.Controls.Page
    {
        public HomeView()
        {
            InitializeComponent();
            cadInfo.txtRow1.Text = "Text 1";
            cadInfo.txtRow2.Text = "Text 2";
        }
    }
}
