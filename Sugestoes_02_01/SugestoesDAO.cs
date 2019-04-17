using System;
using System.Collections.Generic;
using Sistema.Arquitetura.Library.Core;
using Sistema.Arquitetura.Library.Core.Interface;
using Sistema.Arquitetura.Library.Core.Util.Security;
using 

namespace Sugestoes_02_01.DAO
{
    /// <summary>
    /// Classe de Acesso a Dados da Tabela aluno
    /// </summary>
    public class SugestoesDAO {
        public int idSugestao { get; set; }
        public int idFuncionario { get; set; }
        public int idCampanha { get; set; }
        public string Campo_01 { get; set; }
        public string Campo_02 { get; set; }
        public string Campo_03 { get; set; }
        public string Campo_04 { get; set; }
        public string Campo_05 { get; set; }
        public string Campo_06 { get; set; }
        public string Campo_07 { get; set; }
        public int FLVencedora { get; set; }
    }
}