using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore02.Models
{
    public class OrganizerProfile
    {
        public int OrganizerProfileID { get; set; }
        public string? Bio { get; set; }
        public string? Website { get; set; }
        public string? Logo { get; set; }

        #region Relations
        //Organizer
        public Organizer Organizer { get; set; } = null!;
        public int OrganizerID { get; set; }
        #endregion
    }
}
