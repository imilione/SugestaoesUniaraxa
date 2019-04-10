using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sugestoes_02_01.VO
{
    class Campanha_has_Funcionarios
    {
        #region Propriedades - FK
        [Key]
        [Display(Name = "campanha_has_funcionarios_id_funcionario", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanha_has_Funcionarios))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanha_has_Funcionarios), ErrorMessageResourceName = "campanha_has_funcionarios_id_funcionario_required")]
        [ForeignKey("Funcionarios")]
        public int IdFuncionario { get; set; }
        #endregion

        #region Propriedades - FK
        [Key]
        [Display(Name = "campanha_has_funcionarios_id_campanha", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanha_has_Funcionarios))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanha_has_Funcionarios), ErrorMessageResourceName = "campanha_has_funcionarios_id_campanha")]
        [ForeignKey("Campanhas")]
        public int IdCampanha { get; set; }
        #endregion
    }
}
