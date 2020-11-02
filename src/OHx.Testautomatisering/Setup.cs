using BoDi;
using OHx.Testautomatisering.NWADB;
using OHx.Testautomatisering.NWWDB;
using OHx.Testautomatisering.OHX_SCHRIJFDB;
using OHx.Testautomatisering.Services;
using OHx.Testautomatisering.Testdata;
using TechTalk.SpecFlow;

namespace DocumentStore.Testautomatisering
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
        public void StartBagUpdateService()
        {
            // Create and configure a concrete instance of IDocumentStore
            IBagUpdateService bagUpdateService = new BagUpdateService(new OhxSchrijfDbContext(), new NwaDbContext(), new NwwDbContext());

            // Make this instance available to all other step definitions
            _container.RegisterInstanceAs(bagUpdateService);
        }
    }
}
