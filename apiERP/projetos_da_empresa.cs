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
    
    public partial class projetos_da_empresa
    {
        public projetos_da_empresa()
        {
            this.projetos_realizados = new HashSet<projetos_realizados>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public Nullable<int> INT_ID_PLANEJAMENTO { get; set; }
        public Nullable<int> INT_ID_CLIENTE_FONTE_RESCURSO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_OBS { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual planejamento planejamento { get; set; }
        public virtual ICollection<projetos_realizados> projetos_realizados { get; set; }
    }
}
