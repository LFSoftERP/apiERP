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
    
    public partial class subtipo_norma
    {
        public subtipo_norma()
        {
            this.agendamento_cooperado = new HashSet<agendamento_cooperado>();
            this.autorizacao_generica = new HashSet<autorizacao_generica>();
            this.cadastro_entrada = new HashSet<cadastro_entrada>();
            this.composicao_amostra = new HashSet<composicao_amostra>();
            this.contrato = new HashSet<contrato>();
            this.fechamento_mercado_futuro = new HashSet<fechamento_mercado_futuro>();
            this.instrucao_lote_resultado_para_gerar = new HashSet<instrucao_lote_resultado_para_gerar>();
            this.instrucao_preparo = new HashSet<instrucao_preparo>();
            this.lote_armazem_terceiros = new HashSet<lote_armazem_terceiros>();
            this.lote_resultado_rebeneficio = new HashSet<lote_resultado_rebeneficio>();
            this.ordem_de_producao = new HashSet<ordem_de_producao>();
            this.situacaonorma_subtiponorma = new HashSet<situacaonorma_subtiponorma>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public string TXT_SIGLA_NOMECLATURA_LOTE { get; set; }
    
        public virtual ICollection<agendamento_cooperado> agendamento_cooperado { get; set; }
        public virtual ICollection<autorizacao_generica> autorizacao_generica { get; set; }
        public virtual ICollection<cadastro_entrada> cadastro_entrada { get; set; }
        public virtual ICollection<composicao_amostra> composicao_amostra { get; set; }
        public virtual ICollection<contrato> contrato { get; set; }
        public virtual ICollection<fechamento_mercado_futuro> fechamento_mercado_futuro { get; set; }
        public virtual ICollection<instrucao_lote_resultado_para_gerar> instrucao_lote_resultado_para_gerar { get; set; }
        public virtual ICollection<instrucao_preparo> instrucao_preparo { get; set; }
        public virtual ICollection<lote_armazem_terceiros> lote_armazem_terceiros { get; set; }
        public virtual ICollection<lote_resultado_rebeneficio> lote_resultado_rebeneficio { get; set; }
        public virtual ICollection<ordem_de_producao> ordem_de_producao { get; set; }
        public virtual ICollection<situacaonorma_subtiponorma> situacaonorma_subtiponorma { get; set; }
    }
}
