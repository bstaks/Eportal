//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EkartDataModel.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gener
    {
        public Gener()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int GenId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
