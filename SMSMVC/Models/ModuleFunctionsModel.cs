using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SMSMVC.Models
{
    [Table("ModulesFunctions")]
    public class ModuleFunctionsModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Module_Functions_Id { get; set; }
        public string Module_Function_Name { get; set; }
        public string Module_Function_Description { get; set; }

        public int Module_Id { get; set; }
        public ModulesModel ModulesModel { get; set; }
    }
}