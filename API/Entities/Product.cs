namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Prod_name { get; set; }
        public string Prod_desc { get; set; }
        public long Price { get; set; }
        public string Prod_pics { get; set; }
        public string Prod_type { get; set; }
        public string Brand { get; set; }
        public int QuantityInStock { get; set; }
    }
}