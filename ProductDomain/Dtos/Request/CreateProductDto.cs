namespace ProductDomain.Dtos.Request
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }  
        public List<int> Tags { get; set; }
    }
}
