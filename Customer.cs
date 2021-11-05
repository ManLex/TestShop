using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebTest
{
    public partial class Customer
    {
        public Customer()
        {
            Announcements = new HashSet<Announcement>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "ФІО")]
        public string Name { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
