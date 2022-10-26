namespace SuggestionAppLibrary.Models
{
    public class SuggestionModel
    {
      [BsonId]
      [BsonRepresentation(BsonType.ObjectId)]
      public string Id { get; set; }
      public string Suggestion { get; set; }
      public string Description { get; set; }
      public DateTime DateCreated { get; set; } = DateTime.UtcNow;
      public CategoryModel Category { get; set; }
      public BasicsUserModel Author { get; set; }
      public HashSet<string> UserVotes { get; set; } = new();
      public StatusModel SuggestionStatus { get; set; }
      //Notes I/Team will be add
      public string OwnerNotes { get; set; }
      //pass the community guidance
      public bool ApprovedForRelease { get; set; } = false;
      //item archieved 
      public bool Archived { get; set; } = false;
      //After approved for release then do rejection
      public bool Rejected { get; set; } = false;

   }
}
