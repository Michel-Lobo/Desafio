using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DesafioWeb.ViewModels
{
    public class ClienteVM
    {
        [Key]
        public int IDCliente { get; set; }
        [Display(Name ="Nome")]
        [Required(ErrorMessage ="Informe o nome do cliente")]
        public string NomeCliente { get; set; }
        [Display(Name = "Porte da Empresa")]
        [Required(ErrorMessage = "Informe o porte da empresa")]
        public int IDPorteEmpresa { get; set; }
        public String NomePorteEmpresa { get; set; }
    }
}