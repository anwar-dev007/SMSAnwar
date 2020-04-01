using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SMSMVC.Models
{
    [Table("Modules")]
    public class ModulesModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Module_Id { get; set; }
        public string Module_Name { get; set; }
        public string Module_Description { get; set; }
    }
}