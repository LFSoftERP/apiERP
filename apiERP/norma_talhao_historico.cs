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
    
    public partial class norma_talhao_historico
    {
        public int INT_ID { get; set; }
        public int INT_ID_HISTORITCO_TALHAO { get; set; }
        public int INT_ID_NORMA { get; set; }
    
        public virtual historico_talhao historico_talhao { get; set; }
        public virtual norma_talhao norma_talhao { get; set; }
    }
}
