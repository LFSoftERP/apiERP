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
    
    public partial class ordem_de_producao_produtos
    {
        public int INT_ID { get; set; }
        public int INT_ID_OP { get; set; }
        public Nullable<int> INT_ID_PRODUTO { get; set; }
        public Nullable<int> INT_ID_LOTE_PRODUTO { get; set; }
        public decimal DECIMAL_QUANTIDADE { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual funcionario funcionario { get; set; }
        public virtual lote_produto lote_produto { get; set; }
        public virtual ordem_de_producao ordem_de_producao { get; set; }
        public virtual produtos_contabeis produtos_contabeis { get; set; }
    }
}