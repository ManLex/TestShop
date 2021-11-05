using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebTest
{
    public partial class Announcement
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Поле не може бути порожнім")]
        [Display(Name = "Назва ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Опис")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Час додавання ")]
        public TimeSpan TimeAdd { get; set; }
        [Display(Name = "Схожі ")]
        public string LikeAs { get; set; }
        
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Продавець")]
        public virtual Customer Customer { get; set; }
    }
}
