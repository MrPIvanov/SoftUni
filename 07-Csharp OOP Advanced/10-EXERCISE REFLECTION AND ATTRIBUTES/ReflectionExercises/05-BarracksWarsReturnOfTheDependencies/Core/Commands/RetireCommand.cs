using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }


        public  RetireCommand(string[] data, IRepository repository)
            : base(data)
        {
            this.Repository = repository;
        }

        public override string Execute()
        {
            var unitType = this.Data[1];
            try
            {
                this.Repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (Exception e)
            {
                throw new ArgumentException("No such units in repository.", e);
            }
           
        }
    }
}
