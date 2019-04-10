using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sugestoes_02_01.VO
{
    class Funcionarios
    {
        [Key]
        public int IdFuncionario { get; set; }

        [Display(Name = "funcionarios_nome", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesFuncionarios))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesFuncionarios), ErrorMessageResourceName = "funcionarios_nome_required")]
        public string Nome { get; set; }

        [Display(Name = "funcionarios_CPF", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesFuncionarios))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesFuncionarios), ErrorMessageResourceName = "funcionarios_CPF_required")]
        public string CPF { get; set; }

        [Display(Name = "funcionarios_login", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesFuncionarios))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesFuncionarios), ErrorMessageResourceName = "funcionarios_login_required")]
        public string Login { get; set; }

        [Display(Name = "funcionarios_senha", ResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesFuncionarios))]
        [Required(ErrorMessageResourceType = typeof(Sugestoes_02_01.VO.Resources.ResourcesFuncionarios), ErrorMessageResourceName = "funcionarios_senha_required")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
