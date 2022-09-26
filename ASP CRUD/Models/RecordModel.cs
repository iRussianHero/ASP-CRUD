namespace ASP_CRUD.Models
{
    public class RecordModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public RecordModel()
        {
            Id = "N/a";
            Name = "None";
            Description = "Nothing";
        }
        public RecordModel(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
