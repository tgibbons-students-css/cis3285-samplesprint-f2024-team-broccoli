namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        // I am updating this class for User story 1A!
        // This is a comment for User Story 2D - Jonny Saldin
        public RoomRecord(string name, int roomId)
        {
            // I am updating this RoomRecord method for User story 1A!
            Name = name;
            RoomId1 = roomId;
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            get;
            private set;
        }
    }
}
