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
    
    public partial class rank
    {
        public rank()
        {
            this.formulario_subitem_rank = new HashSet<formulario_subitem_rank>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public decimal DECIMAL_NOTA { get; set; }
    
        public virtual ICollection<formulario_subitem_rank> formulario_subitem_rank { get; set; }
    }
}
