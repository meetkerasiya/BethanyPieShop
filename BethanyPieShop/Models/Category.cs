namespace BethanyPieShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }=String.Empty;
        public List<Pie> Pies { get; set; }
    }
}
