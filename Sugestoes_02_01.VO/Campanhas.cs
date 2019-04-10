using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sugestoes_02_01.VO
{
    class Campanhas
    {
        [Key]
        public int IdCampanha { get; set; }

        [Display(Name = "campanhas_nome", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas), ErrorMessageResourceName = "campanhas_nome_required")]
        public string Nome { get; set; }

        [Display(Name = "campanhas_dat_ini", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas), ErrorMessageResourceName = "campanhas_dat_ini_required")]
        [DataType(DataType.DateTime)]
        public DateTime DataInicio { get; set; }

        [Display(Name = "campanhas_dat_fim", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas), ErrorMessageResourceName = "campanhas_dat_fim_required")]
        [DataType(DataType.DateTime)]
        public DateTime DataFim { get; set; }

        #region Propriedades - FK
        [Display(Name = "campanhas_id_escolhe_vencedor", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas), ErrorMessageResourceName = "campanhas_id_escolhe_vencedor_required")]
        [ForeignKey("Funcionarios")]
        public virtual int IdEscolheVencedor { get; set; }
        #endregion

        #region Propriedades - FK
        [Display(Name = "campanhas_id_criar_campanha", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas), ErrorMessageResourceName = "campanhas_id_criar_campanha_required")]
        [ForeignKey("Funcionarios")]
        public virtual int IdCriarCampanha { get; set; }
        #endregion

        #region Propriedades - FK
        [Display(Name = "campanhas_id_funcionario", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesCampanhas), ErrorMessageResourceName = "campanhas_id_funcionario_required")]
        [ForeignKey("Funcionarios")]
        public virtual int IdFuncionario { get; set; }
        #endregion
    }
}
