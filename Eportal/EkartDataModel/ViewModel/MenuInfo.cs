using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkartDataModel.DataModel;
namespace EkartDataModel.ViewModel
{
 public  class MenuInfo
    {
     public Menu _menu { get; set; }
     public string Id { get; set; }
     public string Name { get; set; }
     public List<MenuInfo> _childMenu { get; set; }
    }
}
