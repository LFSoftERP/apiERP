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
    
    public partial class rastrear_transferencias_entre_contas
    {
        public int INT_ID { get; set; }
        public int INT_ID_MOVIMENTO_ORIGEM { get; set; }
        public int INT_ID_MOVIMENTO_DESTINO { get; set; }
        public decimal DECIMAL_VALOR_TRANSFERIDO { get; set; }
        public decimal DECIMAL_VALOR_BRUTO { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual movimento_bancario movimento_bancario { get; set; }
        public virtual movimento_bancario movimento_bancario1 { get; set; }
    }
}