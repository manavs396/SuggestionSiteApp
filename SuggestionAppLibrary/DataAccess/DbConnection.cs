using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace SuggestionAppLibrary.DataAccess;
public class DbConnection : IDbConnection
{
   private readonly IConfiguration config;
   private readonly IMongoDatabase database;
   private string ConnectionId = "MongoDB";
   public string DbName { get; private set; }

   public string CategoryCollectionName { get; private set; } = "categories";
   public string StatusCollectionName { get; private set; } = "statuses";
   public string UserCollectionName { get; private set; } = "users";
   public string SuggestionCollectionName { get; private set; } = "suggestions";

   public MongoClient Client { get; private set; }

   public IMongoCollection<CategoryModel> CategoryCollection { get; private set; }
   public IMongoCollection<StatusModel> StatusCollection { get; private set; }
   public IMongoCollection<UserModel> UserCollection { get; private set; }
   public IMongoCollection<SuggestionModel> SuggestionCollection { get; private set; }



   public DbConnection(IConfiguration config)
   {
      this.config = config;
      Client = new MongoClient(config.GetConnectionString(ConnectionId));
      DbName = config["DatabaseName"];
      database = Client.GetDatabase(DbName);

      CategoryCollection = database.GetCollection<CategoryModel>(CategoryCollectionName);
      StatusCollection = database.GetCollection<StatusModel>(StatusCollectionName);
      UserCollection = database.GetCollection<UserModel>(UserCollectionName);
      SuggestionCollection = database.GetCollection<SuggestionModel>(SuggestionCollectionName);
   }

}
