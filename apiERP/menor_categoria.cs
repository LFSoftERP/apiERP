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
    
    public partial class menor_categoria
    {
        public menor_categoria()
        {
            this.planejamento_menor_categoria = new HashSet<planejamento_menor_categoria>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_MAIOR_CATEGORIA { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual maior_categoria maior_categoria { get; set; }
        public virtual ICollection<planejamento_menor_categoria> planejamento_menor_categoria { get; set; }
    }
}