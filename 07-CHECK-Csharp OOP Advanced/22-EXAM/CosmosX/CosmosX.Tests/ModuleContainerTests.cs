namespace CosmosX.Tests
{
    using CosmosX.Entities.Containers;
    using CosmosX.Entities.Modules.Absorbing;
    using CosmosX.Entities.Modules.Absorbing.Contracts;
    using CosmosX.Entities.Modules.Energy;
    using CosmosX.Entities.Modules.Energy.Contracts;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ModuleContainerTests
    {
        [Test]
        public void AddEnergyModuleCorect()
        {
            var moduleContainer = new ModuleContainer(4);

            IEnergyModule energyModule = new CryogenRod(1, 100);

            moduleContainer.AddEnergyModule(energyModule);

            var actualResult = moduleContainer.ModulesByInput.Count;
            var expectedResult = 1;

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void AddAbsorbingModuleCorect()
        {
            var moduleContainer = new ModuleContainer(4);

            IAbsorbingModule absorbingModule = new HeatProcessor(1 ,123);

            moduleContainer.AddAbsorbingModule(absorbingModule);

            var actualResult = moduleContainer.ModulesByInput.Count;
            var expectedResult = 1;

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void AddMoreEnergyModulesCorect()
        {
            var moduleContainer = new ModuleContainer(2);

            IEnergyModule energyModule = new CryogenRod(1, 100);
            IEnergyModule energyModule2 = new CryogenRod(2, 1001);
            IEnergyModule energyModule3 = new CryogenRod(3, 1002);

            moduleContainer.AddEnergyModule(energyModule);
            moduleContainer.AddEnergyModule(energyModule2);
            moduleContainer.AddEnergyModule(energyModule3);

            var actualResult = moduleContainer.ModulesByInput.Count;
            var expectedResult = 2;

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void SameKeyThrows()
        {
            var moduleContainer = new ModuleContainer(5);

            IEnergyModule energyModule = new CryogenRod(1, 100);
            IEnergyModule energyModule2 = new CryogenRod(1, 1001);

            moduleContainer.AddEnergyModule(energyModule);

            var actualResult = "";
            try
            {
                moduleContainer.AddEnergyModule(energyModule2);
            }
            catch (Exception ex)
            {
                actualResult = ex.Message;
            }

            var expectedResult = "An item with the same key has already been added. Key: 1";

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void AddEnergyModuleCorectTestTotalEnergy()
        {
            var moduleContainer = new ModuleContainer(4);

            IEnergyModule energyModule = new CryogenRod(1, 100);

            moduleContainer.AddEnergyModule(energyModule);

            var actualResult = moduleContainer.TotalEnergyOutput;
            var expectedResult = 100;

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void AddAbsorbingModuleCorectTestHeatAbsorbing()
        {
            var moduleContainer = new ModuleContainer(4);

            IAbsorbingModule absorbingModule = new HeatProcessor(1, 123);

            moduleContainer.AddAbsorbingModule(absorbingModule);

            var actualResult = moduleContainer.TotalHeatAbsorbing;
            var expectedResult = 123;

            Assert.AreEqual(actualResult, expectedResult);
        }


        [Test]
        public void AddNullEnergyModuleThrows()
        {
            var moduleContainer = new ModuleContainer(4);

            IEnergyModule energyModule = null;

            var actualResult = "";
            try
            {
                moduleContainer.AddEnergyModule(energyModule);

            }
            catch (Exception ex)
            {
                actualResult = ex.Message;
            }
           
            var expectedResult = "Value does not fall within the expected range.";

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void AddNullAbsorbingModuleThrows()
        {
            var moduleContainer = new ModuleContainer(4);

            IAbsorbingModule energyModule = null;

            var actualResult = "";
            try
            {
                moduleContainer.AddAbsorbingModule(energyModule);

            }
            catch (Exception ex)
            {
                actualResult = ex.Message;
            }

            var expectedResult = "Value does not fall within the expected range.";

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}