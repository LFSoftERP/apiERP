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
    
    public partial class aplicador_de_produtos_na_lavoura
    {
        public int INT_ID { get; set; }
        public int INT_FORM_APLICAR_PRODUTOS_UTILIZADOS_NA_LAVOURA { get; set; }
        public string TXT_APLICADOR { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual formulario_aplicar_produtos_utilizados_na_lavoura formulario_aplicar_produtos_utilizados_na_lavoura { get; set; }
    }
}
