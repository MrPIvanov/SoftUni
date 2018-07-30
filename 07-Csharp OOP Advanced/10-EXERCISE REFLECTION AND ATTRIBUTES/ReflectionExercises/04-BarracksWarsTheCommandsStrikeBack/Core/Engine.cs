namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;
    using System.Reflection;
    using System.Linq;
    using _03BarracksFactory.Core.Commands;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        private string InterpredCommand(string[] data, string commandName)
        {
            
            var assembly = Assembly.GetCallingAssembly();
            var commandType = assembly.GetTypes().FirstOrDefault(c => c.Name.ToLower() == commandName + "command");

            if (commandType==null)
            {
                throw new ArgumentException("Invalid Command");
            }
            if (!typeof(IExecutable).IsAssignableFrom(commandType))
            {
                throw new ArgumentException("Invalid CommandType");
            }

            var instanceParams = new object[] { data, this.repository, this.unitFactory};
            var instance = Activator.CreateInstance(commandType , instanceParams);

            var method = commandType.GetMethods().FirstOrDefault(m=>m.Name== "Execute");

            try
            {
                var methodParams = new object[] { };
                var result = (string)method.Invoke(instance, methodParams);
                return result;
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
            
        }
       
    }
}
