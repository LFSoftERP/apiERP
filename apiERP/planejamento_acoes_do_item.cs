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
    
    public partial class planejamento_acoes_do_item
    {
        public planejamento_acoes_do_item()
        {
            this.planejamento = new HashSet<planejamento>();
            this.planejamento_acoes_do_item_participantes = new HashSet<planejamento_acoes_do_item_participantes>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_ITEM { get; set; }
        public string TXT_ACAO { get; set; }
        public int INT_NUMERO_ACAO { get; set; }
        public Nullable<int> INT_ID_PILAR { get; set; }
        public bool BOOL_CUSTO_FIXO_OU_VARIAVEL { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public Nullable<bool> BOOL_CONSIDERAR_PARA_GERAR_PLANEJAMENTO { get; set; }
    
        public virtual pilar pilar { get; set; }
        public virtual ICollection<planejamento> planejamento { get; set; }
        public virtual planejamento_item planejamento_item { get; set; }
        public virtual ICollection<planejamento_acoes_do_item_participantes> planejamento_acoes_do_item_participantes { get; set; }
    }
}
