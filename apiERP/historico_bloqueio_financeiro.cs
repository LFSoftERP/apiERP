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
    
    public partial class historico_bloqueio_financeiro
    {
        public int INT_ID { get; set; }
        public Nullable<int> INT_ID_CLIENTE { get; set; }
        public bool BOOL_BLOQUEIO { get; set; }
        public string TXT_MOTIVO { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public int ID_LANCOU { get; set; }
        public Nullable<int> INT_ID_COOPERADO { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual cooperado cooperado { get; set; }
        public virtual funcionario funcionario { get; set; }
    }
}