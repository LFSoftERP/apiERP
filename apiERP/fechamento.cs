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
    
    public partial class fechamento
    {
        public fechamento()
        {
            this.lotes_do_fechamento_e_hedge = new HashSet<lotes_do_fechamento_e_hedge>();
        }
    
        public int INT_ID { get; set; }
        public System.DateTime DATE_DATA_FECHAMENTO { get; set; }
        public string TXT_FECHAMENTO { get; set; }
    
        public virtual ICollection<lotes_do_fechamento_e_hedge> lotes_do_fechamento_e_hedge { get; set; }
    }
}