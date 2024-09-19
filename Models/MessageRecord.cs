namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        public MessageRecord(int roomID, string authorName, string text)
        {
            //I'm going to edit this controller in accordance with user story 1B
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
            // This a the comment for the User Story 2A branch - Jonny Saldin
        }

        public int RoomID
        {
            // Changes Sprint 2C -- As a system administrator, I want to serve hundreds of users concurrently -- Grace Hrabik
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
            // This is a comment for the User Story 2A branch - Jonny Saldin
        }

        public string AuthorName
        {
            //I'm going to edit this controller in accordance with user story 1B
            get;
            private set;
        }
    }
}
