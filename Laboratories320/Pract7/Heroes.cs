using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Laboratories320.Pract7
{
    class Heroes
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonIgnoreIfDefault]
        public object HeroesId;
        [BsonIgnoreIfNull]
        public string HeroesName { get; set; }
        [BsonIgnoreIfDefault]
        public int Health { get; set; }



        public static async Task HeroesInsert(Heroes hr)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Moovi");
            var collection = database.GetCollection<Heroes>("Heroes");
            await collection.InsertOneAsync(hr);
        }

        public static async Task HeroesNameResault(string heroesName, Heroes newHeroes)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Moovi");
            var collection = database.GetCollection<Heroes>("Heroes");
            await collection.ReplaceOneAsync(heroes => heroes.HeroesName == heroesName, newHeroes);
        }
    }

    
}
