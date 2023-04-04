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
    
    public partial class emprestimos
    {
        public emprestimos()
        {
            this.contas_a_pagar_planejamento = new HashSet<contas_a_pagar_planejamento>();
            this.movimento_bancario = new HashSet<movimento_bancario>();
            this.parcela_emprestimo = new HashSet<parcela_emprestimo>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_COOPERADO { get; set; }
        public int INT_ID_CATEGORIA { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public int INT_ID_FUNC { get; set; }
        public Nullable<int> INT_ID_AVALISTA { get; set; }
        public int INT_ID_FORMA_DE_PAGAMENTO { get; set; }
        public bool BOOL_JUROS_AA_AM { get; set; }
        public decimal DECIMAL_PERCENTUAL_JUROS { get; set; }
        public decimal DECIMAL_PERCENTUAL_JUROS_APOS_VENCIMENTO { get; set; }
        public string TXT_FINALIDADE { get; set; }
        public decimal DECIMAL_VALOR { get; set; }
        public System.DateTime DATE_AGENDAR_TRANSFERENCIA { get; set; }
        public string TXT_OBS { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public Nullable<int> INT_ID_SEGUNDO_AVALISTA { get; set; }
        public decimal DECIMAL_VALOR_MUDAS { get; set; }
    
        public virtual categoria_de_emprestimo categoria_de_emprestimo { get; set; }
        public virtual ICollection<contas_a_pagar_planejamento> contas_a_pagar_planejamento { get; set; }
        public virtual cooperado cooperado { get; set; }
        public virtual cooperado cooperado1 { get; set; }
        public virtual cooperado cooperado2 { get; set; }
        public virtual forma_de_pagamento forma_de_pagamento { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual ICollection<movimento_bancario> movimento_bancario { get; set; }
        public virtual ICollection<parcela_emprestimo> parcela_emprestimo { get; set; }
    }
}
