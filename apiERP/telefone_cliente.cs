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
    
    public partial class telefone_cliente
    {
        public int INT_ID { get; set; }
        public string TXT_TELEFONE { get; set; }
        public string TXT_OBS { get; set; }
        public int INT_ID_CLIENTE { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual cliente cliente { get; set; }
    }
}
