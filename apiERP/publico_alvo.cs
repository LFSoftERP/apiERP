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
    
    public partial class publico_alvo
    {
        public publico_alvo()
        {
            this.memorando_publico_alvo = new HashSet<memorando_publico_alvo>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual ICollection<memorando_publico_alvo> memorando_publico_alvo { get; set; }
    }
}