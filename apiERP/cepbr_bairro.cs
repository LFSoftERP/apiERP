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
    
    public partial class cepbr_bairro
    {
        public cepbr_bairro()
        {
            this.cepbr_enderecos = new HashSet<cepbr_enderecos>();
        }
    
        public int id_bairro { get; set; }
        public string bairro { get; set; }
        public Nullable<int> id_cidade { get; set; }
    
        public virtual cepbr_cidade cepbr_cidade { get; set; }
        public virtual ICollection<cepbr_enderecos> cepbr_enderecos { get; set; }
    }
}
