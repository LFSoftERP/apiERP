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
    
    public partial class unidade_de_medida
    {
        public unidade_de_medida()
        {
            this.cotacao_item = new HashSet<cotacao_item>();
            this.cotacao_resultado_itens = new HashSet<cotacao_resultado_itens>();
            this.produtos_contabeis = new HashSet<produtos_contabeis>();
            this.requisito_compra_itens = new HashSet<requisito_compra_itens>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public string TXT_ABREV { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual ICollection<cotacao_item> cotacao_item { get; set; }
        public virtual ICollection<cotacao_resultado_itens> cotacao_resultado_itens { get; set; }
        public virtual ICollection<produtos_contabeis> produtos_contabeis { get; set; }
        public virtual ICollection<requisito_compra_itens> requisito_compra_itens { get; set; }
    }
}