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
    
    public partial class pronaf_pronaf_tipo
    {
        public int INT_ID { get; set; }
        public int INT_ID_PRONAF_TIPO { get; set; }
        public int INT_ID_PRONAF { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual pronaf pronaf { get; set; }
        public virtual pronaf_tipo pronaf_tipo { get; set; }
    }
}