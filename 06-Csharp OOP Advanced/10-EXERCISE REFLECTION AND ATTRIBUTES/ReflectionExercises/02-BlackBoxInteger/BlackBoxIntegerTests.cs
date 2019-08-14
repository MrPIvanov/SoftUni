namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var type = typeof(BlackBoxInteger);
            var classInstance = Activator.CreateInstance(type,true); // find  private constructor
            var fieldToPrint = type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);


            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var tokens = command.Split('_');
                var methodName = tokens[0];
                var value = int.Parse(tokens[1]);

                var methodToExecute = type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
                methodToExecute.Invoke(classInstance, new object[] { value });

                var resultToPrint = fieldToPrint.GetValue(classInstance);
                Console.WriteLine(resultToPrint);
            }
        }
    }
}
