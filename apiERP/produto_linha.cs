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
    
    public partial class produto_linha
    {
        public produto_linha()
        {
            this.lote_produto = new HashSet<lote_produto>();
            this.portifolio_fornecedor = new HashSet<portifolio_fornecedor>();
            this.produtos_contabeis = new HashSet<produtos_contabeis>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_LINHA { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public int INT_ID_EMPRESA { get; set; }
    
        public virtual empresa empresa { get; set; }
        public virtual ICollection<lote_produto> lote_produto { get; set; }
        public virtual ICollection<portifolio_fornecedor> portifolio_fornecedor { get; set; }
        public virtual ICollection<produtos_contabeis> produtos_contabeis { get; set; }
    }
}
