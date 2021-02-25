﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; } = "Информация страницы";

        [Display(Name = "Содержание страницы")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
