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
    
    public partial class tipo_de_inspecao
    {
        public tipo_de_inspecao()
        {
            this.agendamento_certificacao = new HashSet<agendamento_certificacao>();
            this.solicitar_visita = new HashSet<solicitar_visita>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_CONSULTORIA_INSPECAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual ICollection<agendamento_certificacao> agendamento_certificacao { get; set; }
        public virtual ICollection<solicitar_visita> solicitar_visita { get; set; }
    }
}
