# Mastering .NET 8: Unlock the Power of Enhanced Data Annotations for Superior Data Validation and Clean Code🔥https://youtu.be/c-YTdp5_3gE
![data annotation](https://github.com/Netcode-Hub/DemoDataAnnotationInDotNet8/assets/110794348/ca840520-457a-4197-932e-ee4f67cae86e)

# What do these annotations do?
1. AllowedValues: This annotation restricts the values that can be assigned to the Categories property. Only the specified values "Electronics," "Books," "Sneakers," and "Appliances" are allowed. This ensures that the category of a product is always valid.

2. Range: For the Quantity property, the Range annotation specifies that the value must be between 1 and 100, with both bounds being exclusive. This is particularly useful for ensuring quantities fall within a specific, acceptable range without including the boundary values.

3. DeniedValues: This annotation on the Tags property prevents the use of specific values like "Product" and "Category." It's a handy way to enforce that certain strings are not used, which might otherwise cause conflicts or errors in your application logic.

4. Length and StringLength: These annotations on the Location property enforce length constraints on the list and its elements. The Length annotation ensures the list has between 6 and 10 items, while StringLength makes sure each string in the list is between 2 and 6 characters long. This is excellent for ensuring data consistency and avoiding unexpected errors.

By leveraging these annotations, you can add robust validation rules directly to your data models, making your code more reliable and easier to maintain. These features in .NET 8 represent a significant step forward in simplifying data validation and ensuring your applications behave as expected.

# Exmple
      public class Product
          {
              public string? Description { get; set; }
      
              [AllowedValues("Electronics", "Books", "Sneakers", "Appliances")]
              public string? Categories { get; set; }
        
              [Range(1, 100, MinimumIsExclusive = true, MaximumIsExclusive = true)]
              public int Quantity { get; set; }
      
              [DeniedValues("Product", "Category")]
              public string? Tag { get; set; }
      
              [Length(2, 4)]
              public List<string>? Location { get; set; }
          }
# Here's a follow-up section to encourage engagement and support for Netcode-Hub:
🌟 Get in touch with Netcode-Hub! 📫
1. GitHub: [Explore Repositories](https://github.com/Netcode-Hub/Netcode-Hub) 🌐
2. Twitter: [Stay Updated](https://twitter.com/NetcodeHub) 🐦
3. Facebook: [Connect Here](https://web.facebook.com/NetcodeHub) 📘
4. LinkedIn: [Professional Network](https://www.linkedin.com/in/netcode-hub-90b188258/) 🔗
5. Email: Email: [business.netcodehub@gmail.com](mailto:business.netcodehub@gmail.com) 📧
   
# ☕️ If you've found value in Netcode-Hub's work, consider supporting the channel with a coffee!
1. Buy Me a Coffee: [Support Netcode-Hub](https://www.buymeacoffee.com/NetcodeHub) ☕️
2. Patreon: [Support on Patreon](https://patreon.com/user?u=113091185&utm_medium=unknown&utm_source=join_link&utm_campaign=creatorshare_creator&utm_content=copyLink) 🌟
