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
    
    public partial class propriedade
    {
        public propriedade()
        {
            this.agendamento_talhao_propriedade = new HashSet<agendamento_talhao_propriedade>();
            this.historico_talhao = new HashSet<historico_talhao>();
            this.talhao = new HashSet<talhao>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_IE { get; set; }
        public Nullable<int> INT_ID_COOPERADO { get; set; }
        public Nullable<float> TXT_AREA_PASTO { get; set; }
        public Nullable<float> TXT_AREA_TOTAL { get; set; }
        public Nullable<float> TXT_AREA_PRODUCAO { get; set; }
        public Nullable<float> TXT_AREA_RESERVA_LEGAL { get; set; }
        public Nullable<float> TXT_AREA_VEGETACAO { get; set; }
        public Nullable<float> TXT_AREA_APP { get; set; }
        public Nullable<float> TXT_AREA_OUTROS_CULTIVOS { get; set; }
        public string TXT_LATITUDE { get; set; }
        public string TXT_LONGITUDE { get; set; }
        public Nullable<float> FLOAT_ALTITUDE { get; set; }
        public string CHAR_SITUACAO_PROPRIEDADE { get; set; }
        public string TXT_BAIRRO { get; set; }
        public string TXT_CEP { get; set; }
        public string TXT_CIDADE { get; set; }
        public string TXT_RUA { get; set; }
        public string TXT_COMPLEMENTO { get; set; }
        public string INT_NUMERO { get; set; }
        public bool BOOL_END_PRINC { get; set; }
        public string TXT_UF { get; set; }
        public bool BOOL_FLAG_ATIVO_EXCLUIDO { get; set; }
        public Nullable<int> INT_ID_CEP_ENDERECO { get; set; }
        public Nullable<float> FLOAT_PERCENTUAL_DA_PROPRIEDADE { get; set; }
        public Nullable<float> FLOAT_OUTRAS_AREAS { get; set; }
        public Nullable<System.DateTime> DATE_DATA_VALIDADE_CONTRATO { get; set; }
        public string TXT_OBS { get; set; }
        public string TXT_CAR { get; set; }
        public bool BOOL_RESIDENCIA { get; set; }
        public string TXT_CAMINHO_MAPEAMENTO_PDF { get; set; }
        public string TXT_DESCREVER_ACESSO_PROPRIEDADE { get; set; }
    
        public virtual ICollection<agendamento_talhao_propriedade> agendamento_talhao_propriedade { get; set; }
        public virtual cepbr_enderecos cepbr_enderecos { get; set; }
        public virtual cooperado cooperado { get; set; }
        public virtual ICollection<historico_talhao> historico_talhao { get; set; }
        public virtual ICollection<talhao> talhao { get; set; }
    }
}
