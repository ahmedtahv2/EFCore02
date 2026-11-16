using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace EFCore02.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int OrganizerID { get; set; }
        [MaxLength(100),Required]
        public string Name { get; set; } = null!;
        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }

        #region Relations
        //OrgnaizerProfile
        public OrganizerProfile? OrganizerProfile { get; set; }
        //Event
        public ICollection<Event> Events { get; set; } = new List<Event>();
        #endregion

    }
}
