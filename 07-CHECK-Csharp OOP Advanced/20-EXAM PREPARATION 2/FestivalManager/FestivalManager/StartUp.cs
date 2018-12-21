using FestivalManager.Core;
using FestivalManager.Core.Contracts;
using FestivalManager.Core.Controllers;
using FestivalManager.Core.Controllers.Contracts;
using FestivalManager.Core.IO;
using FestivalManager.Core.IO.Contracts;
using FestivalManager.Entities;
using FestivalManager.Entities.Contracts;
using FestivalManager.Entities.Factories;
using FestivalManager.Entities.Factories.Contracts;

namespace FestivalManager
{
	public static class StartUp
	{
		public static void Main()
		{
            IStage stage = new Stage();

            IInstrumentFactory instrumentFactory = new InstrumentFactory();

            ISetFactory setFactory = new SetFactory();

            IFestivalController festivalController = new FestivalController(stage, instrumentFactory, setFactory);

            ISetController setController = new SetController(stage);            

            IReader reader = new ConsoleReader();

            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(festivalController, setController, reader, writer);

            engine.Run();
		}
	}
}