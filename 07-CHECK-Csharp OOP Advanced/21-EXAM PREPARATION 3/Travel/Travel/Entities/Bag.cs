using System.Collections.Generic;
using System.Linq;
using Travel.Entities.Contracts;
using Travel.Entities.Items.Contracts;

namespace Travel.Entities
{
	public class Bag : IBag
	{
		private readonly List<IItem> items;

		public Bag(IPassenger owner, IEnumerable<IItem> items)
		{
			this.Owner = owner;
			this.items = items.ToList();
		}

		public IPassenger Owner { get; private set; }

		public IReadOnlyCollection<IItem> Items => this.items.AsReadOnly();
	}
}