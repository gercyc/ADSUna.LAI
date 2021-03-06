﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADSUna.LAI.Portal.Web.Layout.Models
{
    [Serializable]
    [Table("ITS_MENU")]
    public class Menu
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdMenu { get; set; }
        [StringLength(300)]
        public string NomeMenu { get; set; }
        public Nullable<int> MenuPai { get; set; }
        public bool Status { get; set; }
        [StringLength(500)]
        public string MenuText { get; set; }
        [StringLength(50)]
        public string MenuType { get; set; }
        public string ControllerClass { get; set; }
        public string ActionController { get; set; }
        public Menu()
        {
        }
    }
}
