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
    
    public partial class baixa_valor_adiantado
    {
        public int INT_ID { get; set; }
        public int INT_ID_VENDA_PRSTACAO_SERVICO { get; set; }
        public int INT_ID_MOVIMENTO_BANCARIO { get; set; }
        public decimal DECIMAL_VALOR { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual movimento_bancario movimento_bancario { get; set; }
        public virtual venda_prestacao_servico venda_prestacao_servico { get; set; }
    }
}
