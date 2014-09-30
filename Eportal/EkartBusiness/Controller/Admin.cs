using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkartDataModel.DataModel;
using EkartDataModel.ViewModel;
namespace EkartBusiness.Controller
{
    public class Admin
    {
        public static IEnumerable<MenuInfo> GetMenu()
        {
            try
            {

                using (MusicStoreEntities dbContext = new MusicStoreEntities())
                {
                    IEnumerable<Menu> menu = dbContext.Menus.Where(m => m.MenuType == (int)EnumType.AdminMenuType.ParentMenu && m.ParentMenuId == 0).Select(m => m).ToList();
                    List<MenuInfo> GetMenu = new List<MenuInfo>();

                    foreach (Menu m in menu.ToList())
                    {
                        MenuInfo m1 = new MenuInfo();
                        m1._menu = m;
                        m1._childMenu = GetChildMenu(m.MenuId).ToList();
                        GetMenu.Add(m1);

                    }
                    return GetMenu;
                }
            }

            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static IEnumerable<MenuInfo> GetChildMenu(int MenuId)
        {
            try
            {
                using (MusicStoreEntities dbContext = new MusicStoreEntities())
                {

                    List<Menu> menu = dbContext.Menus.Where(m => m.ParentMenuId == MenuId).Select(m => m).ToList();
                    List<MenuInfo> GetMenu = new List<MenuInfo>();

                    foreach (Menu m in menu)
                    {
                        MenuInfo m1 = new MenuInfo();
                        m1._menu = m;
                        m1._childMenu = GetChildMenu(m.MenuId).ToList();
                        GetMenu.Add(m1);
                    }
                    return GetMenu;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
