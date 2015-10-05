using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Football.Models;
using MongoDB.Bson.Serialization.Serializers;

namespace MongoDb.Data
{
    public class MongoDbRepository
    {
        private const string connectionString = "mongodb://localhost:27017";
        private static readonly MongoClient client = new MongoClient(connectionString);
        private static readonly IMongoDatabase database = client.GetDatabase("Football");
        private static readonly IMongoCollection<BsonDocument> collection =
           database.GetCollection<BsonDocument>("Teams");

        public async Task<IList<Team>> GetData()
        {
            var teams = (await collection.Find(new BsonDocument()).ToListAsync())
                .Select(bs => BsonSerializer.Deserialize<Team>(bs)).ToList();

            return teams;
        }
    }

   
}
