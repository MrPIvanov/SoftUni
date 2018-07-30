 namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string command;
            while ((command = Console.ReadLine()) != "HARVEST")
            {
                var result = "";
                switch (command)
                {
                    case "private":
                        result = PrivateFields();
                        break;

                    case "protected":
                        result = ProtectedFields();
                        break;

                    case "public":
                        result = PublicFields();
                        break;

                    case "all":
                        result = AllFields();
                        break;
                }
                Console.WriteLine(result);
            }
        }

        private static string AllFields()
        {
            var type = typeof(HarvestingFields);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            var sb = new StringBuilder();
            foreach (var field in fields)
            {
                if (field.Attributes.ToString() == "Public")
                {
                    sb.AppendLine($"public {field.FieldType.Name} {field.Name}");
                }
                else if (field.Attributes.ToString() == "Private")
                {
                    sb.AppendLine($"private {field.FieldType.Name} {field.Name}");
                }
                else
                {
                    sb.AppendLine($"protected {field.FieldType.Name} {field.Name}");
                }
            }

            var result = sb.ToString().Trim();
            return result;
        }

        private static string PublicFields()
        {
            var type = typeof(HarvestingFields);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var sb = new StringBuilder();
            foreach (var field in fields)
            {
                if (field.Attributes.ToString() == "Public")
                {
                    sb.AppendLine($"public {field.FieldType.Name} {field.Name}");
                }
            }

            var result = sb.ToString().Trim();
            return result;
        }

        private static string ProtectedFields()
        {
            var type = typeof(HarvestingFields);
            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            var sb = new StringBuilder();
            foreach (var field in fields)
            {
                if (field.Attributes.ToString() == "Family")
                {
                    sb.AppendLine($"protected {field.FieldType.Name} {field.Name}");
                }
            }

            var result = sb.ToString().Trim();
            return result;
        }

        private static string PrivateFields()
        {
            var type = typeof(HarvestingFields);
            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            var sb = new StringBuilder();
            foreach (var field in fields)
            {
                if (field.Attributes.ToString()=="Private")
                {
                    sb.AppendLine($"private {field.FieldType.Name} {field.Name}");
                }
            }

            var result = sb.ToString().Trim();
            return result;
        }
    }
}
