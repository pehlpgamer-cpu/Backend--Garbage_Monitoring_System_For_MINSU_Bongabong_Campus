namespace HCI2_web_api.models
{
    public enum binIntegrity
    {
        NeedsReplacement,
        Low,
        High
    }
    public class Trashbin
    {
        public int TrashbinId { get; set; }
        public binIntegrity BinIntegrity { get; set; } 

        public string BodyColor { get; set; } 
        public double StorageSizeInLiters { get; set; }

        public string Location { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
    }
}
