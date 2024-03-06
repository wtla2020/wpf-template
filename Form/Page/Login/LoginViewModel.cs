using Dao.Model;
using Dapper;
using Form.Config;
using Form.Page.MainMenu;
using HandyControl.Controls;
using Stylet;
using System;
using System.Linq;

namespace Form.Page.Login
{
    public class LoginViewModel : Screen
    {
        public static SysUser User { get; set; }
        private LoginView _loginView { get; set; } 
        public void Login()
        {
            using (var db = DBHelper.GetConn())
            {
                var list = db.GetList<SysUser>().ToList();
                if(list.Count == 1)
                {
                    User = list[0];
                    Boot.Manager.ShowWindow(new MainMenuViewModel());
                }
                else
                {
                    throw new Exception("Account password error！");
                }
            }
            this.Close();
        }

        public void Load()
        {
            _loginView = this.View as LoginView;
            DBHelper.Init(SimpleCRUD.Dialect.SQLite, $@"Data Source=SQLite.db;Version=3;");
        }

        public void Close()
        {
            this.RequestClose();
        }
    }
}
