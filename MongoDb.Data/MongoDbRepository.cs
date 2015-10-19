namespace MongoDb.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Football.Models;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization;
    using MongoDB.Driver;

    public class MongoDbRepository
    {


        

        private const string ConnectionString = "mongodb://selenium:telerik@ds029814.mongolab.com:29814/football-manager";
        private static readonly MongoClient Client = new MongoClient(ConnectionString);
        private static readonly IMongoDatabase Database = Client.GetDatabase("football-manager");

        private static readonly IMongoCollection<BsonDocument> teamsCollection = Database.GetCollection<BsonDocument>("Teams");
        private static readonly IMongoCollection<BsonDocument> stadiumsCollection = Database.GetCollection<BsonDocument>("Stadiums");

        public async Task<IList<Team>> GetTeamsData()

        {
            //if (Client.Cluster.Description.State == ClusterState.Disconnected)
            //{
            //    throw new DataException("mongo connection");
            //}

            var teams = (await teamsCollection.Find(new BsonDocument()).ToListAsync())
                .Select(bs => BsonSerializer.Deserialize<Team>(bs)).ToList();

            return teams;
        }

        public async Task<IList<Stadium>> GetStadiumsData()
        {
            //if (Client.Cluster.Description.State == ClusterState.Disconnected)
            //{
            //    throw new DataException("mongo connection");
            //}

            var stadiums = (await stadiumsCollection.Find(new BsonDocument()).ToListAsync())
                .Select(bs => BsonSerializer.Deserialize<Stadium>(bs)).ToList();

            return stadiums;
        }
    }
}