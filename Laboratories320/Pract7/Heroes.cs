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
        public static async Task UpdateMany(string heroesName, int newHealth)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Moovi");
            var collection = database.GetCollection<Heroes>("Heroes");
            var update = Builders<Heroes>.Update.Set(heroes => heroes.Health, newHealth);
            await collection.UpdateManyAsync(heroes => heroes.HeroesName == heroesName, update);
        }
        public static async Task DeleteMany(string heroesName, int newHealth)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Moovi");
            var collection = database.GetCollection<Heroes>("Heroes");
            var delete = Builders<Heroes>.Filter.Eq(heroes => heroes.Health, newHealth);
            await collection.DeleteManyAsync(delete);
        }
        public static async Task Update(string heroesName, int newHealth)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Moovi");
            var collection = database.GetCollection<Heroes>("Heroes");
            var update = Builders<Heroes>.Update.Set(heroes => heroes.Health, newHealth);
            await collection.UpdateOneAsync(heroes => heroes.HeroesName == heroesName, update);
        }
        public static async Task Delete(string heroesName, int newHealth)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("Moovi");
            var collection = database.GetCollection<Heroes>("Heroes");
            var delete = Builders<Heroes>.Filter.Eq(heroes => heroes.Health, newHealth);
            await collection.DeleteOneAsync(delete);
        }
    }

    
}
