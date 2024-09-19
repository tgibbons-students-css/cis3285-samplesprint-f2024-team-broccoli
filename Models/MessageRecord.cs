﻿namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        public MessageRecord(int roomID, string authorName, string text)
        {
            //I'm going to edit this controller in accordance with user story 1B
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
        }

        public string AuthorName
        {
            //I'm going to edit this controller in accordance with user story 1B
            get;
            private set;
        }
    }
}
