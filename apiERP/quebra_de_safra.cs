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
    
    public partial class quebra_de_safra
    {
        public quebra_de_safra()
        {
            this.quebra_de_safra_estimativa = new HashSet<quebra_de_safra_estimativa>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DANO { get; set; }
        public string CHAR_TIPO_DANO { get; set; }
    
        public virtual ICollection<quebra_de_safra_estimativa> quebra_de_safra_estimativa { get; set; }
    }
}
