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
    
    public partial class referenciar_lotes_armazem_terceiros
    {
        public int INT_ID { get; set; }
        public int INT_ID_LOTE_ARMAZEM_TERCEIROS { get; set; }
        public int INT_ID_CADASTRO_LOTES { get; set; }
        public float FLOAT_QTD_SACAS { get; set; }
        public bool BOOL_FLAG { get; set; }
        public float FLOAT_SACAS_USADAS { get; set; }
    
        public virtual cadastro_entrada cadastro_entrada { get; set; }
        public virtual lote_armazem_terceiros lote_armazem_terceiros { get; set; }
    }
}