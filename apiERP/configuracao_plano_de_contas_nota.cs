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
    
    public partial class configuracao_plano_de_contas_nota
    {
        public int INT_ID { get; set; }
        public int INT_ID_PLANO_DE_CONTAS { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public int INT_ID_PRODUTO { get; set; }
    
        public virtual plano_de_contas_contabil plano_de_contas_contabil { get; set; }
        public virtual produtos_contabeis produtos_contabeis { get; set; }
    }
}