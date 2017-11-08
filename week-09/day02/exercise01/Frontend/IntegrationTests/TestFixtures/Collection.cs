using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationTests.TestFixtures
{
    [CollectionDefinition("BaseCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {
    }
}
