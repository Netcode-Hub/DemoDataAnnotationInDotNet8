using System.ComponentModel.DataAnnotations;

namespace DemoDataAnnotationInDotNet8
{
    public class Product
    {

        public string Description { get; set; }
        /// <summary>
        /// AllowedValues: This annotation restricts the values that can be assigned to the Categories property. 
        /// Only the specified values "Electronics," "Books," "Sneakers," and "Appliances" are allowed. 
        /// This ensures that the category of a product is always valid.
        /// </summary>
        [AllowedValues("Electronics", "Books", "Sneakers", "Appliances", ErrorMessage ="")]
        public string Categories { get; set; }

        /// <summary>
        /// Length and StringLength: These annotations on the Location property enforce length constraints 
        /// on the list and its elements. The Length annotation ensures the list has between 6 and 10 items, 
        /// while StringLength makes sure each string in the list is between 2 and 6 characters long. 
        /// This is excellent for ensuring data consistency and avoiding unexpected errors.
        /// </summary>
        [Range(1, 100, MinimumIsExclusive = true, MaximumIsExclusive = true)]
        public int Quantity { get; set; }
        /// <summary>
        /// DeniedValues: This annotation on the Tags property prevents the use of specific values like 
        /// "Product" and "Category." It's a handy way to enforce that certain strings are not used, 
        /// which might otherwise cause conflicts or errors in your application logic.
        /// </summary>
        [DeniedValues("Product", "Category")]
        public string Tags { get; set; }
        /// <summary>
        /// Range: For the Quantity property, the Range annotation specifies that the value must be between 
        /// 1 and 100, with both bounds being exclusive. This is particularly useful for ensuring quantities 
        /// fall within a specific, acceptable range without including the boundary values.
        /// </summary>
        [Length(2, 4)]
        public List<string> Location { get; set; }
    }



    public class MyModel
    {
        [Key]
        public int Id { get; set; }
        [Range(12,14)]
        public int Number { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [CreditCard]
        public string CreditCard { get; set; }
    }
}
