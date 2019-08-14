using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        public ReportCommand(string[] data, IRepository repository) 
            : base(data)
        {
            this.Repository = repository;
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
