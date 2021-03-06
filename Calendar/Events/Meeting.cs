﻿using System;
using System.Linq;

namespace Calendar.Events
{
    [Serializable]
    class Meeting : CalendarEventBase
    {
        private readonly string[] participants;

        public Meeting(DateSpan schedule, string title, string[] participants)
            : base(schedule, title)
        {
            this.participants = participants;
        }

        public string[] Participants { get { return participants; } }

        public override string ToString()
        {
            return "Meeting '" + Title + "' with " + Participants.Aggregate((p1, p2) => p1 + p2) + Environment.NewLine
                   + "start date: " + Schedule.StartTime + Environment.NewLine
                   + "end date: " + Schedule.EndTime + Environment.NewLine;
        }
    }
}