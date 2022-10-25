namespace SuggestionAppLibrary.Models;
public class BasicsUserModel
{
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }
   public string DisplayName { get; set; }
   public BasicsUserModel()
   {

   }
   public BasicsUserModel(UserModel user)
   {
      Id = user.Id;
      DisplayName = user.DisplayName;
   }

}
