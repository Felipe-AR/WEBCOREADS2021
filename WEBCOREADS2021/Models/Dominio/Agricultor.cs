using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREADS2021.Models.Dominio
{
    [Table("Agricultor")]
    public class Agricultor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "O tamanho do campo está inválido", MinimumLength = 5)]
        [DisplayName("Proprietario")]
        [Required(ErrorMessage = "Campo nome do proprietário é obrigatório")]
        public string proprietario { get; set; }

        [StringLength(25, ErrorMessage = "Tamanho do campo município inválido")]
        [Required(ErrorMessage = "Campo Município é obrigatório")]
        [DisplayName("Município")]
        public string municipio { get; set; }

        [StringLength(25, ErrorMessage = "Tamanho do campo bairro inválido")]
        [Required(ErrorMessage = "Campo bairro é obrigatório")]
        [DisplayName("Bairro")]
        public string bairro { get; set; }
        
        [DisplayName("Idade")]
        [Required(ErrorMessage = "Campo idade é obrigatório")]
        [Range(minimum: 18, maximum: 90, ErrorMessage = "Idade entre 18 e 90 anos")]
        public int idade { get; set; }

        [DisplayName("email")]
        [Required(ErrorMessage = "Campo e-mail é obrigatório")]
        [StringLength(35, ErrorMessage = "Campo e-mail superior a 35 caracteres")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail inválido")]
        public string email { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        public string cpf { get; set; }

        public ICollection<Area> areas { get; set; }
    }
}
