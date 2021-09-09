using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREADS2021.Models.Dominio
{
    [Table("Area")]
    public class Area
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Produtor Rural")]
        public Agricultor produtor { get; set; }
        public int produtorID { get; set; }

        [DisplayName("Hectares")]
        [DisplayFormat(DataFormatString = "0:F2", ApplyFormatInEditMode = true)]
        public float hectares { get; set; }

        [DisplayName("Município")]
        [StringLength(25, ErrorMessage = "O tamanho do campo município é inválido")]
        [Required(ErrorMessage = "O campo município é obrigatório.")]
        public string municipio { get; set; }

        [DisplayName("Bairro")]
        [StringLength(25, ErrorMessage = "O tamanho do campo bairro é inválido")]
        [Required(ErrorMessage = "O campo bairro é obrigatório.")]
        public string bairro { get; set; }

        public int gps { get; set; }
        public ICollection<InsumoArea> insumos { get; set; }
    }
}
