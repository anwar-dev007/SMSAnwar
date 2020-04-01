using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SMSMVC.Models
{
    [Table("UserModuleFunction")]
    public class UserModuleFunctionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_Module_Functions_Id { get; set; }

        public bool Is_Active { get; set; }

        public Guid Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int Module_Functions_Id { get; set; }
        public ModuleFunctionsModel ModuleFunctionsModel { get; set; }

        //public int Module_Id { get; set; }
        //public ModulesModel ModulesModel { get; set; }


    }
}