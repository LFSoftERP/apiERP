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
    
    public partial class bebida_padrao
    {
        public bebida_padrao()
        {
            this.bebida = new HashSet<bebida>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public int INT_ID_EMPRESA { get; set; }
    
        public virtual ICollection<bebida> bebida { get; set; }
        public virtual empresa empresa { get; set; }
    }
}