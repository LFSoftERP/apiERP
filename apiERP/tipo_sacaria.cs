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
    
    public partial class tipo_sacaria
    {
        public tipo_sacaria()
        {
            this.contrato = new HashSet<contrato>();
            this.fechamento_mercado_futuro = new HashSet<fechamento_mercado_futuro>();
            this.instrucao_lote_resultado_para_gerar = new HashSet<instrucao_lote_resultado_para_gerar>();
            this.ordem_reensaque = new HashSet<ordem_reensaque>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public int INT_ID_EMPRESA { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_OIC { get; set; }
        public string TXT_DESCRICAO_INGLES { get; set; }
    
        public virtual ICollection<contrato> contrato { get; set; }
        public virtual empresa empresa { get; set; }
        public virtual ICollection<fechamento_mercado_futuro> fechamento_mercado_futuro { get; set; }
        public virtual ICollection<instrucao_lote_resultado_para_gerar> instrucao_lote_resultado_para_gerar { get; set; }
        public virtual ICollection<ordem_reensaque> ordem_reensaque { get; set; }
    }
}
