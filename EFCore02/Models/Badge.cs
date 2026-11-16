using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore02.Models
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public string BadgeNumber { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public string Tier { get; set; } = null!;

        #region Relations
        public int AttendeeID { get; set; }
        public Attendee Attendee { get; set; } = null!; 
        #endregion
    }
}
