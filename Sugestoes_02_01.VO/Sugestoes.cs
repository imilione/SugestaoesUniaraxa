using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sugestoes_02_01.VO
{
    class Sugestoes
    {
        [Key]
        public int IdSugestao { get; set; }

        #region Propriedades - FK
        [Display(Name = "sugestoes_id_funcionario", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes), ErrorMessageResourceName = "sugestoes_id_funcionario_required")]
        [ForeignKey("Campanha_has_Funcionarios")]
        public virtual int IdFuncionario { get; set; }
        #endregion

        #region Propriedades - FK
        [Display(Name = "sugestoes_id_campanha", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes), ErrorMessageResourceName = "sugestoes_id_campanha_required")]
        [ForeignKey("Campanha_has_Funcionarios")]
        public virtual int IdCampanha { get; set; }
        #endregion

        [Display(Name = "sugestoes_campo_01", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        [DataType(DataType.Text)]
        public string Campo_01 { get; set; }

        [Display(Name = "sugestoes_campo_02", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        [DataType(DataType.Text)]
        public string Campo_02 { get; set; }

        [Display(Name = "sugestoes_campo_03", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        [DataType(DataType.Text)]
        public string Campo_03 { get; set; }

        [Display(Name = "sugestoes_campo_04", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        [DataType(DataType.Text)]
        public string Campo_04 { get; set; }

        [Display(Name = "sugestoes_campo_05", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        [DataType(DataType.Text)]
        public string Campo_05 { get; set; }

        [Display(Name = "sugestoes_campo_06", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        [DataType(DataType.Text)]
        public string Campo_06 { get; set; }

        [Display(Name = "sugestoes_campo_07", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        [DataType(DataType.Text)]
        public string Campo_07 { get; set; }

        [Display(Name = "sugestoes_FL_vencedora", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesSugestoes))]
        public bool FLVencedora { get; set; }
    }
}
