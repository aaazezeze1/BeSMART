using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
    public class EventStorageClass2
    {
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Event { get; set; }
        public EventType Type { get; set; }

        public enum EventType
        {
            Personal,
            Work,
            School
        }

        public Color GetColor()
        {
            switch (Type)
            {
                case EventType.Personal:
                    return Color.Pink;
                case EventType.Work:
                    return Color.Blue;
                case EventType.School:
                    return Color.Brown;
                default:
                    return Color.White;
            }
        }
    }
}
