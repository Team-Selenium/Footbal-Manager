using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Football.Models;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver.Core.Clusters;

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

            if (client.Cluster.Description.State == ClusterState.Disconnected)
            {
                throw new DataException();
            }
            //if(collection)
            var teams = (await collection.Find(new BsonDocument()).ToListAsync())
            .Select(bs => BsonSerializer.Deserialize<Team>(bs)).ToList();

            return teams;

        }
    }


}
