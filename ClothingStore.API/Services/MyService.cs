using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingStore.API.Services
{
    public class MyService : IMyService
    {
        public string Welcome(string name)
        {
            return $"Welcome, {name} \n\n{DateTime.Now}";
        }
    }
}
