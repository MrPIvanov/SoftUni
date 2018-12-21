namespace FestivalManager.Tests
{
    using FestivalManager.Core.Controllers;
    using FestivalManager.Core.Controllers.Contracts;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Contracts;
    using FestivalManager.Entities.Instruments;
    using FestivalManager.Entities.Sets;
    using NUnit.Framework;

	[TestFixture]
	public class SetControllerTests
    {
		[Test]
	    public void EnsureSetControllerPerformCorect()
	    {
            IStage stage = new Stage();

            IInstrument instrument = new Guitar();
            IPerformer performer = new Performer("Pesho", 18);
            ISong song = new Song("song1", new System.TimeSpan(0, 10, 0));
            ISet set = new Short("set1");

            performer.AddInstrument(instrument);
            set.AddPerformer(performer);
            set.AddSong(song);
            stage.AddSet(set);

            ISetController setController = new SetController(stage);


            var expectedResult = "1. set1:\r\n-- 1. song1 (10:00)\r\n-- Set Successful";
            var actualResult = "";

            actualResult =  setController.PerformSets();

            Assert.That(expectedResult.Equals(actualResult));
        }

        [Test]
        public void EnsureSetControllerPerformFalse()
        {
            IStage stage = new Stage();

            IInstrument instrument = new Guitar();
            IPerformer performer = new Performer("Pesho", 18);
            ISong song = new Song("song1", new System.TimeSpan(0, 10, 0));
            ISet set = new Short("set1");

            performer.AddInstrument(instrument);
            set.AddPerformer(performer);
            
            stage.AddSet(set);

            ISetController setController = new SetController(stage);


            var expectedResult = "1. set1:\r\n-- Did not perform";
            var actualResult = "";

            actualResult = setController.PerformSets();

            Assert.That(expectedResult.Equals(actualResult));
        }

        [Test]
        public void EnsureSetControllerDecreseWearLevel()
        {
            IStage stage = new Stage();

            IInstrument instrument = new Guitar();
            IPerformer performer = new Performer("Pesho", 18);
            ISong song = new Song("song1", new System.TimeSpan(0, 10, 0));
            ISet set = new Short("set1");

            performer.AddInstrument(instrument);
            set.AddPerformer(performer);
            set.AddSong(song);
            stage.AddSet(set);

            ISetController setController = new SetController(stage);

            setController.PerformSets();

            var actualWear = instrument.Wear;
            var basicWear = 100;

            Assert.AreNotEqual(actualWear, basicWear);
        }

    }
}