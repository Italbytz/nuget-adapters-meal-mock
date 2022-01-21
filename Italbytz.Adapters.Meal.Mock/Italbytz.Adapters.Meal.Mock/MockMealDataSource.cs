using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Italbytz.Ports.Common;
using Italbytz.Ports.Meal;

namespace Italbytz.Adapters.Meal.Mock
{
    public class MockMealDataSource : IDataSource<int, IMeal>
    {
        public MockMealDataSource()
        {
        }

        public Task<IMeal> Retrieve(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IMeal>> RetrieveAll()
        {
            var list = Mocks.Dishes;
            list.AddRange(Mocks.Desserts);
            return list;
        }

    }

}

