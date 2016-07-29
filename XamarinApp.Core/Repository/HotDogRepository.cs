using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Core.Models;

namespace XamarinApp.Core.Repository
{
    public class HotDogRepository
    {
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
