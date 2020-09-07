namespace initProject.Domain.Models
{
    /// <summary>
    //Defines the class definition for Product.
    /// </summary>
    public class Product : IDBEntity<int>
    {
        /// <summary>
        /// Unique Id of the product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nameof the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product Sku
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// Image url of the product
        /// </summary>
        public string PrimaryImage { get; set; }
    }
}
