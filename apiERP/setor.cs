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
    
    public partial class setor
    {
        public setor()
        {
            this.agendamento_certificacao = new HashSet<agendamento_certificacao>();
            this.memorando = new HashSet<memorando>();
            this.pedido_faturamento = new HashSet<pedido_faturamento>();
            this.planejamento = new HashSet<planejamento>();
            this.requisicao_compra = new HashSet<requisicao_compra>();
            this.solicitacao_de_retirada = new HashSet<solicitacao_de_retirada>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual ICollection<agendamento_certificacao> agendamento_certificacao { get; set; }
        public virtual ICollection<memorando> memorando { get; set; }
        public virtual ICollection<pedido_faturamento> pedido_faturamento { get; set; }
        public virtual ICollection<planejamento> planejamento { get; set; }
        public virtual ICollection<requisicao_compra> requisicao_compra { get; set; }
        public virtual ICollection<solicitacao_de_retirada> solicitacao_de_retirada { get; set; }
    }
}
