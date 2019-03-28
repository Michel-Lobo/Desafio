using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DesafioWeb.ViewModels
{
    public class PorteEmpresaVM
    {
        [Key]
        public int IDPorteEmpresa { get; set; }
        [Display(Name = "Porte da Empresa")]
        [Required(ErrorMessage = "Informe o porte da empresa")]
        public string NomePorteEmpresa { get; set; }
    }
}