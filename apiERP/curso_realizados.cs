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
    
    public partial class curso_realizados
    {
        public curso_realizados()
        {
            this.cursos_cooperados = new HashSet<cursos_cooperados>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_CURSO { get; set; }
        public int INT_ID_MINISTRANTE { get; set; }
        public System.DateTime DATA_CURSO { get; set; }
        public System.DateTime DATA_VALIDADE { get; set; }
        public System.DateTime DATA_LANCAMENTO { get; set; }
        public int INT_ID_LANCOU { get; set; }
        public Nullable<System.DateTime> DATA_ULTIMA_ALTERACAO { get; set; }
        public Nullable<int> INT_ID_ULTIMA_ALTERACAO { get; set; }
        public Nullable<System.DateTime> DATA_EXCLUSAO { get; set; }
        public Nullable<int> INT_ID_EXCLUIU { get; set; }
        public string TXT_OBS { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_LOCAL { get; set; }
    
        public virtual curso curso { get; set; }
        public virtual curso_ministrantes curso_ministrantes { get; set; }
        public virtual ICollection<cursos_cooperados> cursos_cooperados { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual funcionario funcionario2 { get; set; }
    }
}