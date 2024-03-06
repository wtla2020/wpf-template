using Form.Page.Dialog;
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
using System.Windows.Shapes;

namespace Form.Page.Login
{
    /// <summary>
    /// LoginView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Role_SearchStarted(object sender, HandyControl.Data.FunctionEventArgs<string> e)
        {
            new DialogView("Select",
                new TableSelectView("select 'Player' as Role UNION all select 'Junior Player' as Role UNION all select 'Non-Player' as Role UNION all select 'Coach' as Role",
                (no, name, par1, par2) =>
                {
                    txtUserRole.Text = no;
                })
            ).ShowDialog();
        }
    }
}
