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
    
    public partial class cotacao_item_fornecedor
    {
        public cotacao_item_fornecedor()
        {
            this.cotacao_resultado_itens = new HashSet<cotacao_resultado_itens>();
        }
    
        public int INT_ID { get; set; }
        public Nullable<int> INT_ID_ITEM { get; set; }
        public Nullable<int> INT_ID_FORNECEDOR { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual cotacao_item cotacao_item { get; set; }
        public virtual ICollection<cotacao_resultado_itens> cotacao_resultado_itens { get; set; }
    }
}
