using MongoDB.Driver;
using MongoDB.Bson;
using System;



public class DBConnection
{
    private MongoClient DBClient;
    public DBConnection(string ConString)
    {
        DBClient = new MongoClient(ConString);
    }
    public IMongoCollection<T> GetCollection<T>(string DBName, string CollectionName)
    {
        IMongoDatabase DB = DBClient.GetDatabase(DBName);
        return DB.GetCollection<T>(CollectionName);
    }


}

