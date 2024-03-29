//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace apiERP
{
    using System;
    using System.Collections.Generic;
    
    public partial class solicitacao_de_retirada
    {
        public solicitacao_de_retirada()
        {
            this.movimentos_produtos_contabeis = new HashSet<movimentos_produtos_contabeis>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_SOLICITACAO { get; set; }
        public string TXT_MOTIVO { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public System.DateTime DATE_SOLICITACAO { get; set; }
        public Nullable<int> INT_ID_CLIENTE { get; set; }
        public Nullable<int> INT_ID_COOPERADO { get; set; }
        public int INT_ID_SOLICITANTE { get; set; }
        public int INT_ID_AUTORIZADO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public Nullable<int> INT_ID_REVISAO_POP { get; set; }
        public Nullable<int> INT_ID_SETOR { get; set; }
        public string TXT_PLANEJAMENTO_PROJETO { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual cooperado cooperado { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual ICollection<movimentos_produtos_contabeis> movimentos_produtos_contabeis { get; set; }
        public virtual revisoes_pop revisoes_pop { get; set; }
        public virtual setor setor { get; set; }
    }
}
