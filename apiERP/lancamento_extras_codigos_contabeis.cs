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
    
    public partial class lancamento_extras_codigos_contabeis
    {
        public lancamento_extras_codigos_contabeis()
        {
            this.movimentos_produtos_contabeis = new HashSet<movimentos_produtos_contabeis>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_CODIGO_CONTABIL { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public System.DateTime DATE_EVENTO { get; set; }
        public decimal DECCIMAL_QUANTIDADE { get; set; }
        public bool BOOL_SAIDA_ENTRADA { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public Nullable<int> INT_NF { get; set; }
    
        public virtual funcionario funcionario { get; set; }
        public virtual ICollection<movimentos_produtos_contabeis> movimentos_produtos_contabeis { get; set; }
        public virtual produtos_contabeis produtos_contabeis { get; set; }
    }
}
