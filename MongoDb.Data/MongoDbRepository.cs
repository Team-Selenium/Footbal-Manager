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

        private static readonly IMongoCollection<BsonDocument> TeamsCollection = Database.GetCollection<BsonDocument>("Teams");
        private static readonly IMongoCollection<BsonDocument> StadiumsCollection = Database.GetCollection<BsonDocument>("Stadiums");

        public async Task<IList<Team>> GetTeamsData()
        {
            var teams = (await TeamsCollection.Find(new BsonDocument()).ToListAsync())
                .Select(bs => BsonSerializer.Deserialize<Team>(bs)).ToList();

            return teams;
        }

        public async Task<IList<Stadium>> GetStadiumsData()
        {
            var stadiums = (await StadiumsCollection.Find(new BsonDocument()).ToListAsync())
                .Select(bs => BsonSerializer.Deserialize<Stadium>(bs)).ToList();

            return stadiums;
        }
    }
}