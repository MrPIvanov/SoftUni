using SIS.MvcFramework.Attributes.Validation;

namespace SMS.App.ViewModels.ProductsModels
{
    public class CreateInputModel
    {
        private const string NameErrorMsg = "Username should be between 4 and 20 characters";
        private const string PriceErrorMessage = "Price need to be between 0.05 and 1000";


        [RequiredSis]
        [StringLengthSis(4, 20, NameErrorMsg)]
        public string Name { get; set; }

        [RequiredSis]
        [RangeSis(typeof(decimal), "0,05", "1000", PriceErrorMessage)]
        public decimal Price { get; set; }
    }
}
