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
    
    public partial class ouvidoria_mensagem
    {
        public int INT_ID { get; set; }
        public int INT_ID_RESPONDEU { get; set; }
        public System.DateTime DATE_RESPONDEU { get; set; }
        public bool BOOL_VISUALIZADO { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public int INT_ID_OUVIDORIA { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual funcionario funcionario { get; set; }
        public virtual ouvidoria ouvidoria { get; set; }
    }
}