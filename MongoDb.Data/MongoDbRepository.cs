namespace MongoDb.Data
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using Football.Models;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization;
    using MongoDB.Driver;
    using MongoDB.Driver.Core.Clusters;

    public class MongoDbRepository
    {
        private const string ConnectionString = "mongodb://selenium:telerik@ds041164.mongolab.com:41164/football-manager-new";
        private static readonly MongoClient Client = new MongoClient(ConnectionString);
        private static readonly IMongoDatabase Database = Client.GetDatabase("football-manager-new");

        private static readonly IMongoCollection<BsonDocument> Collection =
            Database.GetCollection<BsonDocument>("Teams");
        
        public async Task<IList<Team>> GetData()
        {
            //if (Client.Cluster.Description.State == ClusterState.Disconnected)
            //{
            //    throw new DataException("mongo connection");
            //}

            var teams = (await Collection.Find(new BsonDocument()).ToListAsync())
                .Select(bs => BsonSerializer.Deserialize<Team>(bs)).ToList();

            return teams;
        }
    }
}