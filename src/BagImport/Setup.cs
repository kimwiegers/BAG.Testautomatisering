using BagImport.Testautomatisering.Services;
using BoDi;
using OHx.Testautomatisering.NWADB;
using OHx.Testautomatisering.NWWDB;
using TechTalk.SpecFlow;

namespace BagImport.Testautomatisering
{
    [Binding]
    public class Setup
    {
        private readonly IObjectContainer _container;

        public Setup(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario(Order = 0)]
        public void StartBagImportService()
        {
            // Create and configure a concrete instance of IDocumentStore
            IBagImportService bagImportService = new BagImportService(new NwaDbContext(), new NwwDbContext());

            // Make this instance available to all other step definitions
            _container.RegisterInstanceAs(bagImportService);
        }
    }
}
