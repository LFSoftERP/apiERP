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
    
    public partial class planejamento
    {
        public planejamento()
        {
            this.categoria_de_emprestimo = new HashSet<categoria_de_emprestimo>();
            this.contas_a_pagar_planejamento = new HashSet<contas_a_pagar_planejamento>();
            this.planejamento_data_realizacao = new HashSet<planejamento_data_realizacao>();
            this.planejamento_responsavel = new HashSet<planejamento_responsavel>();
            this.projetos_da_empresa = new HashSet<projetos_da_empresa>();
            this.projetos_realizados = new HashSet<projetos_realizados>();
            this.transferencia_recurso_planejamento_utilizado = new HashSet<transferencia_recurso_planejamento_utilizado>();
            this.transferencia_recursos = new HashSet<transferencia_recursos>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_PERIODO { get; set; }
        public int INT_ID_ACAO { get; set; }
        public decimal DECIMAL_ORCAMENTO_FT { get; set; }
        public decimal DECIMAL_ORCADO_OUTRAS_FONTES { get; set; }
        public decimal DECIMAL_ORCADO_EMPRESA { get; set; }
        public decimal DECIMAL_ORCAMENTO_TOTAL { get; set; }
        public string CHAR_TIPO_ORCAMENTO { get; set; }
        public string TXT_AUTO_AVALIACAO { get; set; }
        public string TXT_IMPACTO { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public int INT_ID_SETOR { get; set; }
        public Nullable<int> INT_ID_FONTE_DE_RECURSO { get; set; }
        public decimal DECIMAL_REALIZADO_OUTRAS_FONTES { get; set; }
        public bool BOOL_SALARIO { get; set; }
        public decimal DECIMAL_TAXA_DOLAR_MEDIA { get; set; }
        public decimal DECIMAL_TOTAL_EM_DOLAR { get; set; }
        public decimal DECIMAL_SALDO_INICIAL { get; set; }
        public decimal DECIMAL_SALDO_EM_DOLAR { get; set; }
        public Nullable<int> INT_ID_CONTA_CONTABIL { get; set; }
    
        public virtual ICollection<categoria_de_emprestimo> categoria_de_emprestimo { get; set; }
        public virtual ICollection<contas_a_pagar_planejamento> contas_a_pagar_planejamento { get; set; }
        public virtual fonte_de_recurso fonte_de_recurso { get; set; }
        public virtual planejamento_acoes_do_item planejamento_acoes_do_item { get; set; }
        public virtual plano_de_contas_contabil plano_de_contas_contabil { get; set; }
        public virtual planejamento_periodo planejamento_periodo { get; set; }
        public virtual setor setor { get; set; }
        public virtual ICollection<planejamento_data_realizacao> planejamento_data_realizacao { get; set; }
        public virtual ICollection<planejamento_responsavel> planejamento_responsavel { get; set; }
        public virtual ICollection<projetos_da_empresa> projetos_da_empresa { get; set; }
        public virtual ICollection<projetos_realizados> projetos_realizados { get; set; }
        public virtual ICollection<transferencia_recurso_planejamento_utilizado> transferencia_recurso_planejamento_utilizado { get; set; }
        public virtual ICollection<transferencia_recursos> transferencia_recursos { get; set; }
    }
}
