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
    
    public partial class quebra_de_safra_estimativa
    {
        public int INT_ID { get; set; }
        public int INT_ID_QUEBRA_SAFRA { get; set; }
        public int INT_ID_ESTIMATIVA { get; set; }
        public int INT_PORCENTAGEM { get; set; }
        public string TXT_OBS { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual estimativa estimativa { get; set; }
        public virtual quebra_de_safra quebra_de_safra { get; set; }
    }
}
