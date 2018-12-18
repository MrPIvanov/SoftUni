using FestivalManager.Core.Controllers.Contracts;
using FestivalManager.Entities;
using FestivalManager.Entities.Contracts;
using FestivalManager.Entities.Factories.Contracts;
using System;
using System.Linq;
using System.Text;

namespace FestivalManager.Core.Controllers
{
	public class FestivalController : IFestivalController
	{
		private readonly IStage stage;
        private readonly ISetFactory setFactory;
        private readonly IInstrumentFactory instrumentFactory;

        public FestivalController(IStage stage, IInstrumentFactory instrumentFactory, ISetFactory setFactory)
		{
			this.stage = stage;
            this.setFactory = setFactory;
            this.instrumentFactory = instrumentFactory;
		}

        public string RegisterSet(string[] args)
        {
            var name = args[0];
            var type = args[1];

            var set = this.setFactory.CreateSet(name, type);

            this.stage.AddSet(set);

            return $"Registered {type} set";
        }

        public string SignUpPerformer(string[] args)
        {
            var name = args[0];
            var age = int.Parse(args[1]);

            IPerformer performer = new Performer(name, age);

            var instrumentNames = args.Skip(2).ToArray();

            var instruments = instrumentNames
                .Select(i => this.instrumentFactory.CreateInstrument(i))
                .ToArray();

            foreach (var instrument in instruments)
            {
                performer.AddInstrument(instrument);
            }

            this.stage.AddPerformer(performer);

            return $"Registered performer {performer.Name}";
        }

        public string RegisterSong(string[] args)
        {
            var name = args[0];
            var durationTokens = args[1].Split(':').ToArray();

            var mins = int.Parse(durationTokens[0]);
            var secs = int.Parse(durationTokens[1]);

            var time = new TimeSpan(0, mins, secs);

            ISong song = new Song(name, time);

            this.stage.AddSong(song);

            return $"Registered song {song}";
        }

        public string AddSongToSet(string[] args)
        {
            var songName = args[0];
            var setName = args[1];

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException("Invalid set provided");
            }

            if (!this.stage.HasSong(songName))
            {
                throw new InvalidOperationException("Invalid song provided");
            }

            var set = this.stage.GetSet(setName);
            var song = this.stage.GetSong(songName);

            set.AddSong(song);

            return $"Added {song} to {set.Name}";
        }

        public string AddPerformerToSet(string[] args)
        {
            var performerName = args[0];
            var setName = args[1];

            if (!this.stage.HasPerformer(performerName))
            {
                throw new InvalidOperationException("Invalid performer provided");
            }

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException("Invalid set provided");
            }

            var performer = this.stage.GetPerformer(performerName);
            var set = this.stage.GetSet(setName);

            set.AddPerformer(performer);

            return $"Added {performer.Name} to {set.Name}";
        }

        public string RepairInstruments(string[] args)
        {
            var instrumentsToRepair = this.stage.Performers
                .SelectMany(p => p.Instruments)
                .Where(i => i.Wear < 100)
                .ToArray();

            foreach (var instrument in instrumentsToRepair)
            {
                instrument.Repair();
            }

            return $"Repaired {instrumentsToRepair.Length} instruments";
        }

        public string ProduceReport()
		{
			var sb = new StringBuilder();

            sb.AppendLine("Results:");

			var totalFestivalLength = new TimeSpan(this.stage.Sets.Sum(s => s.ActualDuration.Ticks));

            sb.AppendLine($"Festival length: {FormatTimeSpanToString(totalFestivalLength)}");

            foreach (var set in this.stage.Sets)
			{
                sb.AppendLine($"--{set.Name} ({FormatTimeSpanToString(set.ActualDuration)}):");

                var performersOrderedDescendingByAge = set.Performers.OrderByDescending(p => p.Age);

				foreach (var performer in performersOrderedDescendingByAge)
				{
					var instruments = string.Join(", ", performer.Instruments
						.OrderByDescending(i => i.Wear));

                    sb.AppendLine($"---{performer.Name} ({instruments})");
				}

				if (!set.Songs.Any())
                    sb.AppendLine("--No songs played");
				else
				{
                    sb.AppendLine("--Songs played:");
					foreach (var song in set.Songs)
					{
                        sb.AppendLine($"----{song.Name} ({FormatTimeSpanToString(song.Duration)})");
					}
				}
			}

			return sb.ToString().Trim();
		}

        private string FormatTimeSpanToString(TimeSpan time)
        {
            var hours = time.Hours;
            var mins = time.Minutes;
            var sec = time.Seconds;

            return $"{(hours*60 + mins):d2}:{sec:d2}";
        }
    }
}