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
    
    public partial class criterios
    {
        public criterios()
        {
            this.form_resposta_nc_criterio = new HashSet<form_resposta_nc_criterio>();
            this.formulario_item = new HashSet<formulario_item>();
            this.formulario_sub_item = new HashSet<formulario_sub_item>();
            this.formulario_subitem_ref_criterio = new HashSet<formulario_subitem_ref_criterio>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public string TXT_NR_NORMA { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public int INT_ID_CERTIFICACAO { get; set; }
        public int INT_ID_CADASTRO { get; set; }
        public System.DateTime DATE_CADASTRO { get; set; }
        public Nullable<int> INT_ID_ALTERACAO { get; set; }
        public Nullable<System.DateTime> DATE_ALTERACAO { get; set; }
        public Nullable<int> INT_ID_EXCLUSAO { get; set; }
        public Nullable<System.DateTime> DATE_EXCLUSAO { get; set; }
        public string TXT_NORMA_COMPLETA { get; set; }
    
        public virtual certificacao certificacao { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual funcionario funcionario2 { get; set; }
        public virtual ICollection<form_resposta_nc_criterio> form_resposta_nc_criterio { get; set; }
        public virtual ICollection<formulario_item> formulario_item { get; set; }
        public virtual ICollection<formulario_sub_item> formulario_sub_item { get; set; }
        public virtual ICollection<formulario_subitem_ref_criterio> formulario_subitem_ref_criterio { get; set; }
    }
}
