using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkartDataModel.DataModel;
namespace EkartBusiness.Controller
{
    public class Admin
    {
        public static IEnumerable<Menu> GetMenu()
        {
            try
            {
               
                    using (MusicStoreEntities dbContext = new MusicStoreEntities())
                    {
                        IEnumerable<Menu> menu = dbContext.Menus.Where(m => m.MenuType == (int)EnumType.AdminMenuType.ParentMenu && m.ParentMenuId == 0).Select(m => m).ToList();
                        //List<Menu> GetMenu = new List<Menu>();
                        //foreach (Menu m in menu) {
                        //    GetMenu.Add(m);
                        //    GetMenu.AddRange(GetChildMenu(m.ParentMenuId.Value));
                        //}
                        return menu;
                    }
                }
            
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static IEnumerable<Menu> GetChildMenu(int parentMenuId)
        {
            try
            {
                using (MusicStoreEntities dbContext = new MusicStoreEntities())
                {
                    List<Menu> menu = dbContext.Menus.Where(m =>m.ParentMenuId == parentMenuId).Select(m => m).ToList();
                    List<Menu> GetMenu = new List<Menu>();
                   
                    foreach (Menu m in menu)
                    {
                        GetMenu.Add(m);
                        GetMenu.AddRange(GetChildMenu(m.ParentMenuId.Value));
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
