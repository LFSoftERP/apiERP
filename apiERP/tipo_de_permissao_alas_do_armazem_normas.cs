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
    
    public partial class tipo_de_permissao_alas_do_armazem_normas
    {
        public int INT_ID { get; set; }
        public int INT_ID_SITUACAO_NORMA { get; set; }
        public int INT_ID_TIPO_DE_PERMISSAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public Nullable<System.DateTime> DATE_EXCLUSAO { get; set; }
        public Nullable<int> INT_ID_EXCLUIU { get; set; }
        public bool BOOL_PERMITI { get; set; }
    
        public virtual funcionario funcionario { get; set; }
        public virtual situacao_norma situacao_norma { get; set; }
        public virtual tipo_de_permissao_alas_do_armazem tipo_de_permissao_alas_do_armazem { get; set; }
    }
}
