using System.ComponentModel.DataAnnotations.Schema;

namespace invite.Shared
{
    public class Product
    {
        public int Id {get;set;}
        public string Title {get;set;} = string.Empty;
        public string Type {get;set;} = string.Empty;
        public string Description {get;set;} = string.Empty;
        public string ImageUrl {get;set;} = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price {get;set;}
        public int Stock {get;set;}       
    }
}