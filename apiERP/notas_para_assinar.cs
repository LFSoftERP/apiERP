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
    
    public partial class notas_para_assinar
    {
        public int INT_ID { get; set; }
        public int INT_ID_COOPERADO { get; set; }
        public int INT_NT { get; set; }
        public System.DateTime DATE { get; set; }
        public string TXT_FLAG_DESCRICAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public bool BOOL_ASSINADA { get; set; }
    
        public virtual cooperado cooperado { get; set; }
    }
}
