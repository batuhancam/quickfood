//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GetFavorite
    {
        public int UserId { get; set; }
        public int FavoriteId { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Username { get; set; }
        public string Recipe { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}