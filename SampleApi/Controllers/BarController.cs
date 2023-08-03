using EdjCase.JsonRpc.Router;
using SampleApi.Models;

namespace SampleApi.Controllers
{
    public class BarController : RpcController
    {
        public Bar GetById(int id)
        {
            var result = new Bar
            {
                Id = id,
                Description = $"This is bar {id}."
            };

            return result;
        }
    }
}
