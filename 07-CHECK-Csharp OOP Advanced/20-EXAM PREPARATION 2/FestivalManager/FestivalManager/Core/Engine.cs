using FestivalManager.Core.Contracts;
using FestivalManager.Core.Controllers.Contracts;
using FestivalManager.Core.IO.Contracts;
using FestivalManager.Entities.Factories.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace FestivalManager.Core
{
	public class Engine : IEngine
	{
        private readonly IFestivalController festivalController;
        private readonly ISetController setController;
        private IReader reader;
        private IWriter writer;

        public Engine(IFestivalController festivalController,
                      ISetController setController,
                      IReader reader,
                      IWriter writer)
        {
            this.festivalController = festivalController;
            this.setController = setController;
            this.reader = reader;
            this.writer = writer;
        }

		public void Run()
		{
			while (true)
			{
				var input = reader.ReadLine();

				if (input == "END")
                {
                    break;
                }

                var result = "";
                try
				{
                    result = this.ProcessCommand(input);
				}
                catch (TargetInvocationException ex)
                {
                    result = "ERROR: " + ex.InnerException.Message;
                }
                catch (Exception ex)
				{
					result = "ERROR: " + ex.Message;
				}

                writer.WriteLine(result);
			}

			var endResult = this.festivalController.ProduceReport();

            this.writer.WriteLine(endResult);
		}

		public string ProcessCommand(string input)
		{
			var inputArgs = input.Split();

			var command = inputArgs[0];
			var tokens = inputArgs.Skip(1).ToArray();

            var result = "";
			if (command == "LetsRock")
			{
				result = this.setController.PerformSets();
			}
            else
            {
                var festivalControllerMethod = this.festivalController.GetType()
                .GetMethods()
                .FirstOrDefault(x => x.Name == command);

                result = (string)festivalControllerMethod.Invoke(this.festivalController, new object[] { tokens });
            }

            return result;
		}
	}
}