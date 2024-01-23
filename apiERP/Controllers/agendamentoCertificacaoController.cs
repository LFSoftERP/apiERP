using apiERP.Controllers.CertificacaoController;
using apiERP.Controllers.sincronizacaoRetornoAgendaFormularioAplicar;
using ERP_COOPFAM.Controllers.CertificacaoController;
using ERP_COOPFAM.Model.Repository;
using Newtonsoft.Json.Linq;
using objRecebendoAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace apiERP.Controllers
{
    public class agendamentoCertificacaoController : ApiController
    {
        // GET: api/agendamentoCertificacao
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/agendamentoCertificacao/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/agendamentocertificacao/testedisponibilidade")]
        [HttpGet]
        public JObject TesteDisponibilidade()
        {
            retornoApi objReturn = new retornoApi();
            objReturn.Success = true;
            objReturn.Message = "API Dsiponível!!! Atualização 23/01/2024 16:00:00";
            return JObject.FromObject(objReturn);
        }

        [Route("api/agendamentocertificacao/pontoCritico")]
        // POST: api/agendamentoCertificacao
        public JObject setPontoCritico([FromBody]ponto_critico objPontoCritico)
        {
            retornoApi objReturn = new retornoApi();

            try
            {
                pontoCriticoController controller = new pontoCriticoController();
                objReturn = controller.ValidaDados(objPontoCritico.INT_ID, objPontoCritico.TXT_DESCRICAO, objPontoCritico.INT_ID_CERTIFICACAO, objPontoCritico.BOOL_ATIVO, objPontoCritico.BOOL_ATIVO, "API pontoCritico", true);
                
                return JObject.FromObject(objReturn);
            }
            catch (Exception ex)
            {
                objReturn.Success = false;
                objReturn.Message = "Erro ao sincronizar Ponto Critico!!!\n\n" + ex.Message;
                return JObject.FromObject(objReturn);
            }
        }

        [Route("api/agendamentocertificacao/criterio")]
        // POST: api/agendamentoCertificacao
        public JObject setcriterio([FromBody] criterios objcriterio)
        {
            retornoApi objReturn = new retornoApi();

            try
            {
                criteriosController controller = new criteriosController();
                objReturn = controller.ValidaDados(objcriterio.INT_ID, objcriterio.TXT_DESCRICAO,objcriterio.TXT_NORMA_COMPLETA,objcriterio.TXT_NR_NORMA, objcriterio.INT_ID_CERTIFICACAO,
                    objcriterio.BOOL_ATIVO, objcriterio.BOOL_ATIVO, objcriterio.DATE_CADASTRO, objcriterio.INT_ID_CADASTRO, objcriterio.DATE_ALTERACAO,
                    objcriterio.INT_ID_ALTERACAO, objcriterio.DATE_EXCLUSAO, objcriterio.INT_ID_EXCLUSAO, "API criterios", true);

                return JObject.FromObject(objReturn);
            }
            catch (Exception ex)
            {
                objReturn.Success = false;
                objReturn.Message = "Erro ao Sincronizar Critério!!!\n\n" + ex.Message;
                return JObject.FromObject(objReturn);
            }
        }

        [Route("api/agendamentocertificacao/refcriterio")]
        // POST: api/agendamentoCertificacao
        public JObject setrefcriterio([FromBody] formulario_subitem_ref_criterio objRefcriterio)
        {
            retornoApi objReturn = new retornoApi();

            try
            {
                formulario_subitem_ref_criterioController controller = new formulario_subitem_ref_criterioController();
                objReturn = controller.ValidaDados(objRefcriterio.INT_ID, objRefcriterio.TXT_NUM_CRITERIO, objRefcriterio.INT_ID_NORMA, objRefcriterio.INT_ID_CRITERIO,
                    objRefcriterio.BOOL_ATIVO, objRefcriterio.BOOL_ATIVO, objRefcriterio.DATE_CADASTRO, objRefcriterio.INT_ID_CADASTRO, objRefcriterio.DATE_ALTERACAO,
                    objRefcriterio.INT_ID_ALTERACAO, objRefcriterio.DATE_EXCLUSAO, objRefcriterio.INT_ID_EXCLUSAO, "API formulario_subitem_ref_criterio", true);

                return JObject.FromObject(objReturn);
            }
            catch (Exception ex)
            {
                objReturn.Success = false;
                objReturn.Message = "Erro ao Sincronizar Referência do Critério!!!\n\n" + ex.Message;
                return JObject.FromObject(objReturn);
            }
        }

        [Route("api/agendamentocertificacao/potencialrisco")]
        // POST: api/agendamentoCertificacao
        public JObject setpotenciaRisco([FromBody]potencial_risco objPotencialRisco)
        {
            retornoApi objReturn = new retornoApi();

            try
            {
                potencialRiscoController controller = new potencialRiscoController();
                objReturn = controller.ValidaDados(objPotencialRisco.INT_ID, objPotencialRisco.TXT_DESCRICAO, objPotencialRisco.INT_ID_PONTO_CRITICO, objPotencialRisco.BOOL_ATIVO, 
                    objPotencialRisco.BOOL_ATIVO, "API potencialRisco", true);

                return JObject.FromObject(objReturn);
            }
            catch (Exception ex)
            {
                objReturn.Success = false;
                objReturn.Message = "Erro ao Sincronizar Potencial Risco!!!\n\n" + ex.Message;
                return JObject.FromObject(objReturn);
            }
        }
        [Route("api/agendamentocertificacao/procedimentocritico")]
        // POST: api/agendamentoCertificacao
        public JObject setProcedimentocritico([FromBody]procedimento_critico_medida_precaucao objProcedimentoCritico)
        {
            retornoApi objReturn = new retornoApi();

            try
            {
                procedimentoCriticoMedidaPrecaucaoController controller = new procedimentoCriticoMedidaPrecaucaoController();
                objReturn = controller.ValidaDados(objProcedimentoCritico.INT_ID, objProcedimentoCritico.TXT_DESCRICAO, objProcedimentoCritico.INT_ID_PONTO_CRITICO, 
                    objProcedimentoCritico.BOOL_ATIVO, objProcedimentoCritico.BOOL_ATIVO, "API procedimentocritico", true);

                return JObject.FromObject(objReturn);
            }
            catch (Exception ex)
            {
                objReturn.Success = false;
                objReturn.Message = "Erro ao sincronizar Procedimento Critico!!!\n\n" + ex.Message;
                return JObject.FromObject(objReturn);
            }
        }
        [Route("api/agendamentocertificacao/documentocomprobatorio")]
        // POST: api/agendamentoCertificacao
        public JObject setDocumentoComprobatorio([FromBody]documento_comprobatorio objDocumentoComprob)
        {
            retornoApi objReturn = new retornoApi();

            try
            {
                documentoComprobatorioController controller = new documentoComprobatorioController();
                objReturn = controller.ValidaDados(objDocumentoComprob.INT_ID, objDocumentoComprob.TXT_DESCRICAO, objDocumentoComprob.INT_ID_PONTO_CRITICO, objDocumentoComprob.BOOL_ATIVO, 
                    objDocumentoComprob.BOOL_ATIVO, "API DocumentoComprob", true);

                return JObject.FromObject(objReturn);
            }
            catch (Exception ex)
            {
                objReturn.Success = false;
                objReturn.Message = "Erro ao sincronizar documento comprobatório!!!\n\n" + ex.Message;
                return JObject.FromObject(objReturn);
            }
        }
        [Route("api/agendamentocertificacao/formularioitemseletiva")]
        // POST: api/agendamentoCertificacao
        public JObject setItemSeletiva([FromBody]formulario_item_selecao objitemSeletiva)
        {
            retornoApi objReturn = new retornoApi();

            try
            {
                formularioItemSelecaoController controller = new formularioItemSelecaoController();
                objReturn = controller.ValidaDados(objitemSeletiva.INT_ID, objitemSeletiva.TXT_DESCRICAO, objitemSeletiva.TXT_COMPOSICAO, objitemSeletiva.TXT_OBS, objitemSeletiva.TXT_PRINCIPIO_ATIVO,
                    objitemSeletiva.TXT_DOSAGEM, objitemSeletiva.INT_ID_TIPO_PROD_AGRICOLA, objitemSeletiva.INT_ID_EMPRESA_FORN_PROD_AGRICOLA, objitemSeletiva.INT_ID_SELETIVA,
                    objitemSeletiva.INT_DIAS_REENTRADA.ToString(), objitemSeletiva.INT_DIAS_CARENCIA.ToString(), objitemSeletiva.INT_ID_PRAGA_DOENCA_A_SER_COMBATIDA, objitemSeletiva.TXT_COR,
                    objitemSeletiva.BOOL_PERMITIDO_NAO_PERMITIDO, objitemSeletiva.BOOL_PERMITIDO_NAO_PERMITIDO, objitemSeletiva.BOOL_ATIVO, 
                    objitemSeletiva.BOOL_ATIVO, "API formularioitemseletiva", true);

                return JObject.FromObject(objReturn);
            }
            catch (Exception ex)
            {
                objReturn.Success = false;
                objReturn.Message = "Erro ao Sincronizar Item Seleção!!!\n\n" + ex.Message;
                return JObject.FromObject(objReturn);
            }
        }

        [Route("api/agendamentocertificacao/cancelaragenda")]
        // POST: api/agendamentoCertificacao
        public JObject Post([FromBody]agendamento_certificacao objAgCert)
        {
            retornoApi objReturn = new retornoApi();
            objReturn.Success = true;
            objReturn.Message = "Sincronizado com Sucesso!!!";

            try
            {
                IRepository<agendamento_certificacao> repository = new Repository<agendamento_certificacao>();
                agendamento_certificacao obj = repository.Consulta_Id(objAgCert.INT_ID);

                obj.TXT_MOTIVO = objAgCert.TXT_MOTIVO;
                obj.BOOL_VISITA_CANCELADA = objAgCert.BOOL_VISITA_CANCELADA;
                obj.DATE_ALTERACAO = objAgCert.DATE_ALTERACAO;
                obj.INT_ID_ALTERACAO = objAgCert.INT_ID_ALTERACAO;
                obj.BOOL_SINCRONIZACAO_FINALIZOU = true;
                obj.DATE_SINC_FIN = DateTime.Now;

                repository.Update(obj);
                if (!repository.SaveChanges("Cancela Agenda API"))
                {
                    objReturn.Success = false;
                    objReturn.Message = "Erro ao Atualizar Agendamento!!!";
                }

                return JObject.FromObject(objReturn);
            }
            catch (Exception ex)
            {
                objReturn.Success = false;
                objReturn.Message = "Erro ao Cancelar Agenda!!!\n\n" + ex.Message;
                return JObject.FromObject(objReturn);
            }           
        }


        [Route("api/agendamentocertificacao/sincronizarvisitas")]
        // POST: api/agendamentoCertificacao
        public JObject Sincronizar([FromBody]agendamento_certificacao_api objAgCert)
        {
            retornoApi objReturn = new retornoApi();
            objReturn.Success = true;
            objReturn.Message = "Sincronizado com Sucesso!!!";
            try
            {
                IRepository<agendamento_certificacao> repository = new Repository<agendamento_certificacao>();
                objReturn.Message += objAgCert.BOOL_ATIVO;
                
                agendamento_certificacao obj = repository.Consulta_Id(objAgCert.INT_ID);

                configuracoes objConfig = new configuracoes();
                objConfig = new Repository<configuracoes>().GetAll().FirstOrDefault();


                obj.DATE_ALTERACAO = objAgCert.DATE_ALTERACAO;
                obj.INT_ID_ALTERACAO = objAgCert.INT_ID_ALTERACAO;
                obj.BOOL_SINCRONIZACAO_FINALIZOU = true;
                obj.DATE_SINC_FIN = DateTime.Now;
                
                foreach (var item in objAgCert.agendamento_formulario_ser_aplicado.Where(x=>x.BOOL_ATIVO).ToList())
                {
                    foreach (var item2 in item.formulario_aplicar.Where(x=>x.BOOL_ATIVO).ToList())
                    {
                        formulario_aplicar objForm = new formulario_aplicar();

                        objForm.agendamento_formulario_ser_aplicado = obj.agendamento_formulario_ser_aplicado.FirstOrDefault(x => x.INT_ID == item2.INT_ID_AGENDAMENTO_FORMULARIO_SER_APLICADO);
                        objForm.BOOL_APROVADO_GESTOR = item2.BOOL_APROVADO_GESTOR;
                        objForm.BOOL_AROVADO_ANALISTA_SCI = item2.BOOL_AROVADO_ANALISTA_SCI;
                        objForm.BOOL_ATIVO = item2.BOOL_ATIVO;
                        objForm.BOOL_AVALIACAO_PELO_CLIENTE = item2.BOOL_AVALIACAO_PELO_CLIENTE;
                        objForm.BOOL_CADERNO_CAMPO_ATUALIZADO = item2.BOOL_CADERNO_CAMPO_ATUALIZADO;
                        objForm.BOOL_CERTIFICADO_POR_OUTRA_CERTIFICADORA = item2.BOOL_CERTIFICADO_POR_OUTRA_CERTIFICADORA;
                        objForm.BOOL_COLETA_AMOSTRA = item2.BOOL_COLETA_AMOSTRA;
                        objForm.BOOL_CONSEGUIU_FAZER_RASTREABILIDADE = item2.BOOL_CONSEGUIU_FAZER_RASTREABILIDADE;
                        objForm.BOOL_MAPA_CONFORME = item2.BOOL_MAPA_CONFORME;
                        objForm.BOOL_PLANO_CONVERSAO_C_NC_NA = item2.BOOL_PLANO_CONVERSAO_C_NC_NA;
                        objForm.BOOL_SOLICITACAO_REDUCAO_TEMPO_TRANSICAO = item2.BOOL_SOLICITACAO_REDUCAO_TEMPO_TRANSICAO;
                        objForm.CHAR_RESULTADO = item2.CHAR_RESULTADO;
                        objForm.CHAR_VERSAO = item2.CHAR_VERSAO;
                        objForm.DATE_ALTERACAO = item2.DATE_ALTERACAO;
                        objForm.DATE_CADASTRO = item2.DATE_CADASTRO;
                        objForm.DATE_EXCLUSAO = item2.DATE_EXCLUSAO;
                        objForm.DATE_FIM = item2.DATE_FIM;
                        objForm.DATE_INI = item2.DATE_INI;
                        objForm.DECIMAL_TEMPO_CONVERSAO = item2.DECIMAL_TEMPO_CONVERSAO;
                        objForm.INT_ID_AGENDAMENTO_FORMULARIO_SER_APLICADO = item2.INT_ID_AGENDAMENTO_FORMULARIO_SER_APLICADO;

                        objForm.agendamento_formulario_ser_aplicado.INT_ID_AGENDAMENTO = obj.INT_ID;

                        objForm.INT_ID_ALTERACACAO = item2.INT_ID_ALTERACACAO;
                        objForm.INT_ID_APLICOU = item2.INT_ID_APLICOU;
                        objForm.INT_ID_CADASTRO = item2.INT_ID_CADASTRO;
                        objForm.INT_ID_COOPERADO = item2.INT_ID_COOPERADO;
                        objForm.INT_ID_EXCLUSAO = item2.INT_ID_EXCLUSAO;
                        objForm.INT_ID_FORMULARIO = item2.INT_ID_FORMULARIO;
                        objForm.INT_ID_FORMULARIO_APLICAR_RASTREAR = item2.INT_ID_FORMULARIO_APLICAR_RASTREAR;
                        objForm.TXT_CAMINHO_ANEXAR_DOC_REDUCAO_TEMPO_TRANSICAO = item2.TXT_CAMINHO_ANEXAR_DOC_REDUCAO_TEMPO_TRANSICAO;
                        objForm.TXT_CONTATACAO = item2.TXT_CONTATACAO;
                        objForm.TXT_DESCRICAO_BALANCO_MASSA = item2.TXT_DESCRICAO_BALANCO_MASSA;
                        objForm.TXT_DESCRICAO_CERTIFICADORA = item2.TXT_DESCRICAO_CERTIFICADORA;
                        objForm.TXT_DESCRICAO_RASTREABILIDADE = item2.TXT_DESCRICAO_RASTREABILIDADE;
                        objForm.TXT_OBS = item2.TXT_OBS;
                        objForm.TXT_OBS_ANALISTA_SCI = item2.TXT_OBS_ANALISTA_SCI;
                        objForm.TXT_OBS_CADASTRO = item2.TXT_OBS_CADASTRO;
                        objForm.TXT_OBS_GESTOR = item2.TXT_OBS_GESTOR;
                        objForm.TXT_OBS_MAPA = item2.TXT_OBS_MAPA;
                        objForm.TXT_OBS_PLANO_CONVERSAO = item2.TXT_OBS_PLANO_CONVERSAO;
                        objForm.TXT_OBS_REDUCAO_TEMPO_TRANSICAO = item2.TXT_OBS_REDUCAO_TEMPO_TRANSICAO;
                        objForm.TXT_RECOMENDACAO = item2.TXT_RECOMENDACAO;
                        objForm.TXT_OBS_AVALIACAO_CLIENTE = item2.TXT_OBS_AVALIACAO_CLIENTE;
                        objForm.TXT_MOTIVO_DE_NAO_COLETAR_ASSINATURA = item2.TXT_MOTIVO_DE_NAO_COLETAR_ASSINATURA;

                        if (item2.TXT_ASSINATURA != "")
                        {                            
                            // Determine o diretório de destino onde você deseja salvar a imagem.
                            string diretorioDestino = objConfig.TXT_CAMINHO_ASSINATURA;

                            // Gere um nome único para a imagem, por exemplo, com base no ID.
                            string nomeUnico = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff").Replace("-", "").Replace(":", "").Replace(" ", "").Replace(".", "") + ".png" ;

                            // Combine o diretório de destino e o nome do arquivo para obter o caminho completo.
                            string caminhoDestino = Path.Combine(diretorioDestino, nomeUnico);
                            try
                            {
                                // Salve a imagem no servidor.
                                objForm.TXT_ASSINATURA = nomeUnico;
                                File.WriteAllBytes(caminhoDestino, item2.IMAGEM_ASSINATURA);
                            }
                            catch (Exception ex)
                            {
                                objForm.TXT_ASSINATURA = "erro "+ex.Message.ToString();
                            }
                        }                        


                        foreach (var itemFormAppAgTalhao in item2.formulario_aplicar_agendamento_talhao_propriedade.Where(x=>x.BOOL_ATIVO).ToList())
                        {
                            formulario_aplicar_agendamento_talhao_propriedade objFormAppAgTalhao = new formulario_aplicar_agendamento_talhao_propriedade();

                            objFormAppAgTalhao.BOOL_ATIVO = itemFormAppAgTalhao.BOOL_ATIVO;
                            objFormAppAgTalhao.INT_ID_AGENDAMENTO_TALHAO_PROPRIEDADE = itemFormAppAgTalhao.INT_ID_AGENDAMENTO_TALHAO_PROPRIEDADE;
                            objFormAppAgTalhao.INT_ID_FORM_APLICAR = itemFormAppAgTalhao.INT_ID_FORM_APLICAR;

                            objForm.formulario_aplicar_agendamento_talhao_propriedade.Add(objFormAppAgTalhao);
                        }

                        foreach (var itemFormResp in item2.formulario_respostas.Where(x=>x.BOOL_ATIVO).ToList())
                        {
                            formulario_respostas objFormApp = new formulario_respostas();

                            objFormApp.BOOL_ATIVO = itemFormResp.BOOL_ATIVO;
                            objFormApp.BOOL_C_NC_NA_ = itemFormResp.BOOL_C_NC_NA_;
                            objFormApp.BOOL_MANTIDA_PELO_ANALISTA_SCI = itemFormResp.BOOL_MANTIDA_PELO_ANALISTA_SCI;
                            objFormApp.BOOL_MANTIDA_PELO_GESTOR_SCI = itemFormResp.BOOL_MANTIDA_PELO_GESTOR_SCI;
                            objFormApp.BOOL_MEDIDA_PRECAUCAO = itemFormResp.BOOL_MEDIDA_PRECAUCAO;
                            objFormApp.BOOL_REINCIDENTE = itemFormResp.BOOL_REINCIDENTE;
                            objFormApp.BOOL_RESOLVIDO = itemFormResp.BOOL_RESOLVIDO;
                            objFormApp.DATA_PRAZO_RESOLVER_NC = itemFormResp.DATA_PRAZO_RESOLVER_NC;
                            objFormApp.DATE_ALTERACAO = itemFormResp.DATE_ALTERACAO;
                            objFormApp.DATE_CADASTRO = itemFormResp.DATE_CADASTRO;
                            objFormApp.DATE_EXCLUSAO = itemFormResp.DATE_EXCLUSAO;
                            objFormApp.DATE_PRAZO_ENTRAR_EM_CONTATO_ANALISTA_SCI = itemFormResp.DATE_PRAZO_ENTRAR_EM_CONTATO_ANALISTA_SCI;
                            objFormApp.DATE_RESOLVIDO = itemFormResp.DATE_RESOLVIDO;
                            objFormApp.DECIMAL_NOTA = itemFormResp.DECIMAL_NOTA;
                            objFormApp.DECIMAL_NOTA_TOTAL = itemFormResp.DECIMAL_NOTA_TOTAL;
                            objFormApp.INT_ID_ALTERACAO = itemFormResp.INT_ID_ALTERACAO;
                            objFormApp.INT_ID_CADASTRO = itemFormResp.INT_ID_CADASTRO;
                            objFormApp.INT_ID_EXCLUSAO = itemFormResp.INT_ID_EXCLUSAO;
                            objFormApp.INT_ID_FORMULARIO_APP = itemFormResp.INT_ID_FORMULARIO_APP;
                            objFormApp.INT_ID_FORM_SUB_ITEM = itemFormResp.INT_ID_FORM_SUB_ITEM;
                            objFormApp.INT_ID_PONTO_CRITICO = itemFormResp.INT_ID_PONTO_CRITICO;
                            objFormApp.INT_ID_POTENCIAL_RISCO = itemFormResp.INT_ID_POTENCIAL_RISCO;
                            objFormApp.INT_ID_PROCEDIMENTO_CRITICO = itemFormResp.INT_ID_PROCEDIMENTO_CRITICO;
                            objFormApp.INT_ID_FORMULARIO_SUBITEM_RANK = itemFormResp.INT_ID_FORMULARIO_SUBITEM_RANK;
                            objFormApp.TXT_ACAO_CORRETIVA = itemFormResp.TXT_ACAO_CORRETIVA;
                            objFormApp.TXT_CONSTATACAO_INSPETOR = itemFormResp.TXT_CONSTATACAO_INSPETOR;
                            objFormApp.TXT_LATITUDE = itemFormResp.TXT_LATITUDE;
                            objFormApp.TXT_LONGITUDE = itemFormResp.TXT_LONGITUDE;
                            objFormApp.TXT_OBS = itemFormResp.TXT_OBS;
                            objFormApp.TXT_OBS_ANALISTA_SCI = itemFormResp.TXT_OBS_ANALISTA_SCI;
                            objFormApp.TXT_OBS_MANTIDA_PELO_GESTOR_SCI = itemFormResp.TXT_OBS_MANTIDA_PELO_GESTOR_SCI;
                            objFormApp.TXT_OBS_PONTO_CRITICO = itemFormResp.TXT_OBS_PONTO_CRITICO;
                            objFormApp.TXT_OBS_POTENCIAL_RISCO = itemFormResp.TXT_OBS_POTENCIAL_RISCO;
                            objFormApp.TXT_OBS_PROCEDIMENTO_CRITICO = itemFormResp.TXT_OBS_PROCEDIMENTO_CRITICO;
                            objFormApp.TXT_OBS_RESOLUCAO = itemFormResp.TXT_OBS_RESOLUCAO;
                            objFormApp.TXT_RESPOSTA_PMO = itemFormResp.TXT_RESPOSTA_PMO;

                            foreach (var itemSolicitacaoVisita in itemFormResp.solicitar_visita.Where(x=>x.BOOL_ATIVO).ToList())
                            {
                                solicitar_visita objSolicitacao = new solicitar_visita();

                                objSolicitacao.BOOL_ATIVO = itemSolicitacaoVisita.BOOL_ATIVO;
                                objSolicitacao.INT_ID_FORM_RESPOSTA = itemSolicitacaoVisita.INT_ID_FORM_RESPOSTA;
                                objSolicitacao.INT_ID_INSPECAO = itemSolicitacaoVisita.INT_ID_INSPECAO;
                                objSolicitacao.TXT_OBS = itemSolicitacaoVisita.TXT_OBS;

                                objFormApp.solicitar_visita.Add(objSolicitacao);
                            }

                            foreach (var itemDocComprob in itemFormResp.formulario_resposta_documento_comprobatorio.Where(x=>x.BOOL_ATIVO).ToList())
                            {
                                formulario_resposta_documento_comprobatorio objDocComprob = new formulario_resposta_documento_comprobatorio();

                                objDocComprob.BOOL_ATIVO = itemDocComprob.BOOL_ATIVO;
                                objDocComprob.DATE_ALTERACAO = itemDocComprob.DATE_ALTERACAO;
                                objDocComprob.DATE_EXCLUSAO = itemDocComprob.DATE_EXCLUSAO;
                                objDocComprob.DATE_LANCAMENTO = itemDocComprob.DATE_LANCAMENTO;
                                objDocComprob.INT_ID_ALTERACAO = itemDocComprob.INT_ID_ALTERACAO;
                                objDocComprob.INT_ID_DOCUMENTO_COMPROBATORIO = itemDocComprob.INT_ID_DOCUMENTO_COMPROBATORIO;
                                objDocComprob.INT_ID_EXCLUSAO = itemDocComprob.INT_ID_EXCLUSAO;
                                objDocComprob.INT_ID_FORMULARIO_RESPOSTA = itemDocComprob.INT_ID_FORMULARIO_RESPOSTA;
                                objDocComprob.INT_ID_LANCAMENTO = itemDocComprob.INT_ID_LANCAMENTO;
                                objDocComprob.TXT_OBS = itemDocComprob.TXT_OBS;

                                objFormApp.formulario_resposta_documento_comprobatorio.Add(objDocComprob);
                            }

                            foreach (var itemSeletiva in itemFormResp.formulario_resposta_seletiva.Where(x => x.BOOL_ATIVO).ToList())
                            {
                                formulario_resposta_seletiva objSeletiva = new formulario_resposta_seletiva();

                                objSeletiva.BOOL_ATIVO = itemSeletiva.BOOL_ATIVO;
                                objSeletiva.BOOL_USO_EXCLUSIVO = itemSeletiva.BOOL_USO_EXCLUSIVO;
                                objSeletiva.DATE_ALTERACAO = itemSeletiva.DATE_ALTERACAO;
                                objSeletiva.DATE_CADASTRO = itemSeletiva.DATE_CADASTRO;
                                objSeletiva.DATE_EXCLUSAO = itemSeletiva.DATE_EXCLUSAO;
                                objSeletiva.DECIMAL_QTD = itemSeletiva.DECIMAL_QTD;
                                objSeletiva.INT_ID_ALTERACAO = itemSeletiva.INT_ID_ALTERACAO;
                                objSeletiva.INT_ID_CADASTRO = itemSeletiva.INT_ID_CADASTRO;
                                objSeletiva.INT_ID_EXCLUSAO = itemSeletiva.INT_ID_EXCLUSAO;
                                objSeletiva.INT_ID_FORM_RESPOSTA = itemSeletiva.INT_ID_FORM_RESPOSTA;
                                objSeletiva.INT_ID_ITEM_SELECAO = itemSeletiva.INT_ID_ITEM_SELECAO;
                                objSeletiva.TXT_OBS = itemSeletiva.TXT_OBS;

                                objFormApp.formulario_resposta_seletiva.Add(objSeletiva);
                            }

                            foreach (var itemNCCriterio in itemFormResp.form_resposta_nc_criterio.Where(x=>x.BOOL_ATIVO).ToList())
                            {
                                form_resposta_nc_criterio objNCCriterio = new form_resposta_nc_criterio();

                                objNCCriterio.BOOL_ATIVO = itemNCCriterio.BOOL_ATIVO;
                                objNCCriterio.DATE_ALTERACAO = itemNCCriterio.DATE_ALTERACAO;
                                objNCCriterio.DATE_CADASTRO = itemNCCriterio.DATE_CADASTRO;
                                objNCCriterio.DATE_EXCLUSAO = itemNCCriterio.DATE_EXCLUSAO;
                                objNCCriterio.INT_ALTERACAO = itemNCCriterio.INT_ALTERACAO;
                                objNCCriterio.INT_EXCLUSAO = itemNCCriterio.INT_EXCLUSAO;
                                objNCCriterio.INT_ID_CADASTRO = itemNCCriterio.INT_ID_CADASTRO;
                                objNCCriterio.INT_ID_CRITERIO = itemNCCriterio.INT_ID_CRITERIO;
                                objNCCriterio.INT_ID_FORM_RESPOSTA = itemNCCriterio.INT_ID_FORM_RESPOSTA;

                                objFormApp.form_resposta_nc_criterio.Add(objNCCriterio);
                            }

                            foreach (var itemEvidencia in itemFormResp.formulario_resposta_evidencia.Where(x=>x.BOOL_ATIVO).ToList())
                            {
                                formulario_resposta_evidencia objEvidencia = new formulario_resposta_evidencia();

                                objEvidencia.BOOL_ATIVO = itemEvidencia.BOOL_ATIVO;
                                objEvidencia.BOOL_RESOLUCAO = itemEvidencia.BOOL_RESOLUCAO;
                                objEvidencia.INT_ID_FORMULARIO_RESPOSTAS = itemEvidencia.INT_ID_FORMULARIO_RESPOSTAS;
                                objEvidencia.TXT_CAMINHO = itemEvidencia.TXT_CAMINHO;
                                objEvidencia.TXT_FORMATO = itemEvidencia.TXT_FORMATO;
                                objEvidencia.TXT_FOTO_VIDEO_ARQUIVO = itemEvidencia.TXT_FOTO_VIDEO_ARQUIVO;
                                objEvidencia.TXT_LATITUDE = itemEvidencia.TXT_LATITUDE;
                                objEvidencia.TXT_LONGITUDE = itemEvidencia.TXT_LONGITUDE;

                                objFormApp.formulario_resposta_evidencia.Add(objEvidencia);
                            }

                            objForm.formulario_respostas.Add(objFormApp);
                            agendamento_formulario_ser_aplicado teste = obj.agendamento_formulario_ser_aplicado.FirstOrDefault(x => x.INT_ID == 
                                objForm.agendamento_formulario_ser_aplicado.INT_ID);
                            teste.formulario_aplicar.Add(objForm);                            
                        }
                    }

                    //objForm.agendamento_formulario_ser_aplicado = obj.agendamento_formulario_ser_aplicado.FirstOrDefault(x => x.INT_ID == item2.INT_ID_AGENDAMENTO_FORMULARIO_SER_APLICADO);
                }
                                
                repository.Update(obj);
                
                if (!repository.SaveChanges("Sincronizar Visita API"))
                {
                    objReturn.Message = "Erro ao Atualizar!!!";
                    objReturn.Success = false;
                }
                //else
                //{
                //    List<formulario_aplicar_ids> listidsretorno = new List<formulario_aplicar_ids>();

                //    IRepository<agendamento_certificacao> repositoryAtualizado = new Repository<agendamento_certificacao>();
                //    agendamento_certificacao objAtualizado = repositoryAtualizado.Consulta_Id(objAgCert.INT_ID);

                //    foreach (var item in objAtualizado.agendamento_formulario_ser_aplicado.Where(x=>x.BOOL_ATIVO).ToList())
                //    {
                //        foreach (var item2 in item.formulario_aplicar.Where(x=>x.BOOL_ATIVO).ToList())
                //        {
                //            formulario_aplicar_ids objids = new formulario_aplicar_ids();
                //            objids.INT_ID=
                //        }
                //    }
                //}

                return JObject.FromObject(objReturn);
                //return JObject.Parse("{result: \"" + retorno + "\"}");
            }
            catch (Exception ex)
            {
                objReturn.Success = false;
                objReturn.Message += "Erro ao Sincronizar!!!\n\n"+ex.Message;
                return JObject.FromObject(objReturn);
                //return JObject.Parse("{result: \"" + false + "\"}");
            }
        }


        // PUT: api/agendamentoCertificacao/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/agendamentoCertificacao/5
        public void Delete(int id)
        {
        }
    }
}
