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
    
    public partial class planejamento_categoria
    {
        public planejamento_categoria()
        {
            this.planejamento_periodo = new HashSet<planejamento_periodo>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_EXTRAPOLAR { get; set; }
        public bool BOOL_FT { get; set; }
        public int INT_ID_EMPRESA { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual empresa empresa { get; set; }
        public virtual ICollection<planejamento_periodo> planejamento_periodo { get; set; }
    }
}
