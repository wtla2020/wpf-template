using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Linq;
using Dapper;
using Form.Config;
using HandyControl.Controls;

namespace Form.Page.Dialog
{
    /// <summary>
    /// TableSelectView.xaml 的交互逻辑
    /// </summary>
    public partial class TableSelectView : System.Windows.Controls.Page
    {
        public string PageNo { get; set; } = "";
        public string PageName { get; set; } = "";
        public string Attr1 { get; set; } = "";
        public string Attr2 { get; set; } = "";
        public Action<string, string, string, string> Callback { get; set; }
        public TableSelectView(string sql, Action<string,string, string, string> callback)
        {
            InitializeComponent();
            Callback = callback;
            using (var db = DBHelper.GetConn())
            {
                var dt = db.QueryTable(sql);
                this.dgdData.ItemsSource = dt.DefaultView;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectRow = this.dgdData.SelectedItem as DataRowView;
            if(selectRow == null)
            {
                Growl.InfoGlobal("必须选择一行！");
            }
            else
            {
                try
                {
                    PageNo = Convert.ToString(selectRow.Row[0]);
                    PageName = Convert.ToString(selectRow.Row[1]);
                    Attr1 = Convert.ToString(selectRow.Row[2]);
                    Attr2 = Convert.ToString(selectRow.Row[3]);
                }
                catch 
                { 
                    
                }
                Callback(PageNo, PageName, Attr1, Attr2);
                var dg = this.Tag as DialogView;
                dg.Close();
            }
        }

        private void dgdData_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            e.Column.IsReadOnly = true;
        }
    }
}
