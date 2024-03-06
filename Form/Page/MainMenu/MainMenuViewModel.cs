using Form.Control;
using Form.Model;
using Form.Page.Home;
using Form.Page.Login;
using Form.Page.MatchInfo;
using Form.Page.TrainInfo;
using Form.Page.UserInfo;
using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form.Page.MainMenu
{
    public class MainMenuViewModel : Screen
    {
    	public MainMenuView SView { get; set; }
    	public string Title { get; set; }
        public void Load()
        {
        	SView = this.View as MainMenuView;
            Title = $"Test Project({LoginViewModel.User.UserName})";
            List<MenuPageItem> menuPageItems = new List<MenuPageItem>
                {
                    new MenuPageItem { Name = "Home", Page = new HomeView() },
                    new MenuPageItem { Name = "Player", Page = new UserInfoView() },
                    new MenuPageItem { Name = "Match", Page = new MatchInfoView() },
                    new MenuPageItem { Name = "Train", Page = new TrainInfoView() },
                };
            SView.MenuInit(menuPageItems);
        }
        public void MenuSelect(MenuItem menuItem,EventArgs e)
        {

        }
        public void HeaderSelect(TabHeaderItem headItem, EventArgs e)
        {
            this.SView.frmMain.Navigate(headItem.Page);
        }
        public void Close()
        {
            this.RequestClose();
        }
    }
}