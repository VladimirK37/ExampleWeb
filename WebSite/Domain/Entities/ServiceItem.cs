using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage ="Заполните название услуг")]
        [Display(Name = "Название услуг")]
        public override string Title { get; set; }

        [Display(Name = "Краткое поисание услуг")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание услуг")]
        public override string Text { get; set; }
    }
}
