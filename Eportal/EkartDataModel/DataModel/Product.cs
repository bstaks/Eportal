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
    
    public partial class Product
    {
        public Product()
        {
            this.Carts = new HashSet<Cart>();
        }
    
        public int ProductId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string AlbumArtURL { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Gener Gener { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
