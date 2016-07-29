using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Core.Models;
using XamarinApp.Core.Repository;

namespace XamarinApp.Core.Services
{
    public class HotDogService
    {
        private static HotDogRepository repository = new HotDogRepository();

        public IList<HotDog> GetAllHotDogs()
        {
            return new List<HotDog>();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            return new HotDog();
        }

        public IList<HotDogGroup> GetAllHotDogGroups()
        {
            return new List<HotDogGroup>();
        }

        public IList<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            return new List<HotDog>();
        }
    }
}
