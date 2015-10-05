using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDb.Data;

namespace TestApp
{
    class Program
    {
        static  void Main(string[] args)
        {
            var mongo = new MongoDbRepository();

            mongo.GetPlayers().Wait();
        }
    }
}
