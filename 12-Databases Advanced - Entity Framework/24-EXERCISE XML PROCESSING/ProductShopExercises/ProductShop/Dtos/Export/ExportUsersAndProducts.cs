using System.Xml.Serialization;

namespace ProductShop.Dtos.Export
{
    [XmlType("Users")]
    public class ExportUsersAndProducts
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("users")]
        public LocalUserForUserAndProductsDto[] Users { get; set; }
    }

    [XmlType("User")]
    public class LocalUserForUserAndProductsDto
    {   
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("age")]
        public int? Age { get; set; }

        [XmlElement("SoldProducts")]
        public LocalSoldProductsDto SoldProducts { get; set; }
    }

    public class LocalSoldProductsDto
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("products")]
        public LocalProductDto[] Products { get; set; }
    }

    [XmlType("Product")]
    public class LocalProductDto
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }
    }
}