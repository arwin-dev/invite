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
        public int Stock {get;set;}
        public Category? Category { get; set; }
        public int CategoryId {get;set;}
        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();    
    }
}