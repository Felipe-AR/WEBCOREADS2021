using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREADS2021.Models.Dominio
{
    public enum TipoInsumo { Defensivo, Adubo, Semente, Herbicida, Lubrificante, Combustível }

    public class Insumo
    {
        public enum TipoInsumo { Adubo, Semente, Combustivel, Lubrificante, Herbicida, Inseticida, Outros }

        [Key]
        [DisplayName("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(35, ErrorMessage = "Descrição deve ter no máximo 35 caracteres")]
        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Tipo Insumo")]
        public TipoInsumo tipoInsumo { get; set; }

        [DisplayName("Quantidade")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public float quantidade { get; set; }

        [DisplayName("Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float valor { get; set; }

        public ICollection<InsumoArea> areasinsumo { get; set; }
    }
}
