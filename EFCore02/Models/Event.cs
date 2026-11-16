using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore02.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }

        #region Relations
        public int OrganizerID { get; set; }
        public Organizer Organizer { get; set; } 
        #endregion

    }
}
