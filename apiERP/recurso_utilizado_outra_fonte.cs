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
    
    public partial class recurso_utilizado_outra_fonte
    {
        public int INT_ID { get; set; }
        public int INT_ID_CONTAS_A_PAGAR_PLANEJAMENTO { get; set; }
        public int INT_ID_TRANSFERENCIA_RECURSO_PLANEJAMENTO_UTILIZADO { get; set; }
        public decimal DECIMAL_TOTAL_REAIS { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual contas_a_pagar_planejamento contas_a_pagar_planejamento { get; set; }
        public virtual transferencia_recurso_planejamento_utilizado transferencia_recurso_planejamento_utilizado { get; set; }
    }
}
