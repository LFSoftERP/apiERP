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
    
    public partial class historico_de_alteracao_de_status
    {
        public int INT_ID { get; set; }
        public int INT_ID_COOPERADO { get; set; }
        public string CHAR_STATUS_ANTERIOR { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public string CHAR_NOVO_STATUS { get; set; }
        public System.DateTime DATE_EVENTO { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public string TXT_MOTIVO { get; set; }
    
        public virtual cooperado cooperado { get; set; }
    }
}
