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
    
    public partial class parcela_emprestimo
    {
        public parcela_emprestimo()
        {
            this.descontos_acrescimos_pg_cafe = new HashSet<descontos_acrescimos_pg_cafe>();
            this.pagamento_emprestimo = new HashSet<pagamento_emprestimo>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_EMPRESTIMO { get; set; }
        public int INT_NUMERO_DE_PARCELAS { get; set; }
        public System.DateTime DATA_VENCIMENTO { get; set; }
        public decimal DECIMAL_VALOR { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public bool BOOL_INATIVO { get; set; }
        public Nullable<int> INT_ID_RENEGOCIACAO { get; set; }
        public decimal DECIMAL_BAIXA { get; set; }
    
        public virtual ICollection<descontos_acrescimos_pg_cafe> descontos_acrescimos_pg_cafe { get; set; }
        public virtual emprestimos emprestimos { get; set; }
        public virtual emprestimos_renegociacao emprestimos_renegociacao { get; set; }
        public virtual ICollection<pagamento_emprestimo> pagamento_emprestimo { get; set; }
    }
}
