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
    
    public partial class formulario_sub_item
    {
        public formulario_sub_item()
        {
            this.agendamento_certificacao_itens_especificos = new HashSet<agendamento_certificacao_itens_especificos>();
            this.formulario_checklist = new HashSet<formulario_checklist>();
            this.formulario_respostas = new HashSet<formulario_respostas>();
            this.formulario_subitem_rank = new HashSet<formulario_subitem_rank>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_ITEM { get; set; }
        public string TXT_EXPLICACAO { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_RESPOSTA_SUGESTIVA { get; set; }
        public Nullable<int> INT_ID_SELETIVA { get; set; }
        public decimal DECIMAL_PESO { get; set; }
        public bool BOOL_MULTIPLA_ESCOLHA_NOTA { get; set; }
        public int INT_ID_CADASTRO { get; set; }
        public System.DateTime DATE_CADASTRO { get; set; }
        public Nullable<int> INT_ID_ALTERACAO { get; set; }
        public Nullable<System.DateTime> DATE_ALTERACAO { get; set; }
        public Nullable<int> INT_ID_EXCLUSAO { get; set; }
        public Nullable<System.DateTime> DATE_EXCLUSAO { get; set; }
        public string TXT_COR { get; set; }
        public bool BOOL_ELIMINATORIA { get; set; }
        public Nullable<int> INT_ID_SUBITEM_REF_CRITERIO { get; set; }
        public bool BOOL_RANK { get; set; }
        public string TXT_NR { get; set; }
        public Nullable<int> INT_ID_TIPO_CRITERIO { get; set; }
    
        public virtual ICollection<agendamento_certificacao_itens_especificos> agendamento_certificacao_itens_especificos { get; set; }
        public virtual criterios criterios { get; set; }
        public virtual ICollection<formulario_checklist> formulario_checklist { get; set; }
        public virtual formulario_item formulario_item { get; set; }
        public virtual ICollection<formulario_respostas> formulario_respostas { get; set; }
        public virtual formulario_seletiva formulario_seletiva { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual funcionario funcionario2 { get; set; }
        public virtual tipo_de_criterio tipo_de_criterio { get; set; }
        public virtual ICollection<formulario_subitem_rank> formulario_subitem_rank { get; set; }
    }
}
