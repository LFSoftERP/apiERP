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
    
    public partial class emprestimos_renegociacao
    {
        public emprestimos_renegociacao()
        {
            this.emprestimos_renegociacao1 = new HashSet<emprestimos_renegociacao>();
            this.parcela_emprestimo = new HashSet<parcela_emprestimo>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_EMPRESTIMO { get; set; }
        public decimal DECIMAL_VALOR { get; set; }
        public string TXT_OBS_RENEGOCIACAO { get; set; }
        public System.DateTime DATE_RENEGOCIACAO { get; set; }
        public decimal DECIMAL_NOVA_TAXA_DE_JUROS { get; set; }
        public decimal DECIMAL_NOVA_TAXA_DE_JUROS_APOS_VENCIMENTO { get; set; }
        public bool BOOL_JUROS_AA_AM { get; set; }
        public int INT_ID_CADASTROU { get; set; }
        public System.DateTime DATE_LANCOU { get; set; }
        public Nullable<int> INT_ID_ALTEROU { get; set; }
        public Nullable<System.DateTime> DATE_ALTEROU { get; set; }
        public Nullable<int> INT_ID_EXCLUIU { get; set; }
        public Nullable<System.DateTime> DATE_EXCLUIU { get; set; }
        public Nullable<int> INT_ID_RENEGOCIACAO { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual emprestimos emprestimos { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual funcionario funcionario1 { get; set; }
        public virtual funcionario funcionario2 { get; set; }
        public virtual ICollection<emprestimos_renegociacao> emprestimos_renegociacao1 { get; set; }
        public virtual emprestimos_renegociacao emprestimos_renegociacao2 { get; set; }
        public virtual ICollection<parcela_emprestimo> parcela_emprestimo { get; set; }
    }
}