using LittleRestApi.Models;
using LittleRestApi.Services;

namespace LittleRestApiTests.FakeServices
{
    public class FakeSomeDataService : ISomeDataService
    {
        private readonly List<SomeData> _someDatas;
        public FakeSomeDataService()
        {
            _someDatas = new List<SomeData>
            {
                new SomeData{ Data = "somedata1" },
                new SomeData{ Data = "somedata2" },
                new SomeData{ Data = "somedata3" },
                new SomeData{ Data = "somedata4" },
                new SomeData{ Data = "somedata5" },
                new SomeData{ Data = "somedata6" },
                new SomeData{ Data = "somedata7" },
                new SomeData{ Data = "somedata8" },
                new SomeData{ Data = "somedata9" },
                new SomeData{ Data = "somedata10" },
                new SomeData{ Data = "somedata11" },
                new SomeData{ Data = "somedata12" },
                new SomeData{ Data = "somedata13" },
                new SomeData{ Data = "somedata14" },
                new SomeData{ Data = "somedata15" }
            };
        }

        public async Task<List<SomeData>> GetSomeDatasRange(int from = 0, int to = 0)
        {
            var result = _someDatas.Skip(from).Take(to).ToList();
            return result;
        }
    }
}
