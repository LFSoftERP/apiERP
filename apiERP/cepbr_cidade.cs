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
    
    public partial class cepbr_cidade
    {
        public cepbr_cidade()
        {
            this.cepbr_bairro = new HashSet<cepbr_bairro>();
            this.cepbr_enderecos = new HashSet<cepbr_enderecos>();
        }
    
        public int id_cidade { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cod_ibge { get; set; }
        public float area { get; set; }
        public Nullable<int> id_municipio_subordinado { get; set; }
    
        public virtual ICollection<cepbr_bairro> cepbr_bairro { get; set; }
        public virtual ICollection<cepbr_enderecos> cepbr_enderecos { get; set; }
        public virtual cepbr_estado cepbr_estado { get; set; }
    }
}
