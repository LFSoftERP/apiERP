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
    
    public partial class pronaf_tipo
    {
        public pronaf_tipo()
        {
            this.pronaf_pronaf_tipo = new HashSet<pronaf_pronaf_tipo>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_CUSTEIO_INVESTIMENTO { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual ICollection<pronaf_pronaf_tipo> pronaf_pronaf_tipo { get; set; }
    }
}
