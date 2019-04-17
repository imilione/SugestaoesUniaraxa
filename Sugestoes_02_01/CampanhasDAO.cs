using System;
using System.Collections.Generic;
using Sistema.Arquitetura.Library.Core;
using Sistema.Arquitetura.Library.Core.Interface;
using Sistema.Arquitetura.Library.Core.Util.Security;
using Sugestoes_02_01.VO;

namespace Sugestoes_02_01.DAO
{
    class CampanhasDAO
    {
        public int idCampanha { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int idEscolheVencedor { get; set; }
        public int idCriarCampanha { get; set; }
        public int idFuncionario { get; set; }
    }
}
