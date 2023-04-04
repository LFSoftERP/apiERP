using ERP_COOPFAM.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Validation;
using apiERP.Controllers;

namespace ERP_COOPFAM.Controllers.ControllerGenerics
{
    class ControllerGenerics<T>
        where T : class
    {
        public retornoApi retorno { get; set; }

        public ControllerGenerics()
        {
            retorno = new retornoApi();
        }

      
        public void TratamentoDeErro(string lugar, Exception ex)
        {
            try
            {
                new Repository<T>().cadastra_erro(ex.Message, lugar, ex);
            }
            catch (Exception ex1)
            {
                retorno.Success = false;
                retorno.Message= "Erro ao tentar salvar o motivo do erro!!!\n" + ex1.Message;
            }
        }
             
        

        public retornoApi cadastraAltera(bool cadastraAltera, T obj, IRepository<T> repository, string txtRastrear, bool ativo=true)
        {
            try
            {
                if (cadastraAltera)
                    repository.Add(obj);
                else
                    repository.Update(obj);

                if (repository.SaveChanges("classe controllerGenerics CadastraAltera "+ txtRastrear + cadastraAltera))
                {
                    retorno.Success = true;
                    retorno.Message = "Sucesso!!!";
                    return retorno;
                }
                else
                {
                    retorno.Success = false;
                    retorno.Message = "Erro!!!";
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                retorno.Success = false;
                retorno.Message = "Erro ao executar o comando!!!";
                repository.cadastra_erro(ex.Message, "Classe controllerGenerics CadastraAltera NR "+txtRastrear);
                return retorno;
            }
        }


        public bool cadastraAlteraSemMensagem(bool cadastraAltera, T obj, IRepository<T> repository, string txtRastrear)
        {
            try
            {
                if (cadastraAltera)
                    repository.Add(obj);
                else
                    repository.Update(obj);

                if (repository.SaveChanges("classe controllerGenerics CadastraAltera " + txtRastrear + cadastraAltera))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                repository.cadastra_erro(ex.Message, "Classe controllerGenerics CadastraAltera NR " + txtRastrear);
                return false;
            }
        }
        /// <summary>
        /// passar objeto ja com a consulta e setando FALSE na flag de ativo, para a função realizar a alteração
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="txtRastrear">de onde esta função foi chamada se der erro ele cadastra no log</param>
        /// <returns></returns>
        public retornoApi excluir(T obj, string txtRastrear, IRepository<T> repository)
        {
            try
            {
                repository.Update(obj);
                if (repository.SaveChanges("Classe ControllerGenerics Excluir "+ txtRastrear))
                {
                    retorno.Success = true;
                    retorno.Message = "Excluído com Sucesso!!!";
                    return retorno;
                }
                else
                {
                    retorno.Success = false;
                    retorno.Message = "Erro ao Excluir!!!";
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                retorno.Success = false;
                retorno.Message = "Erro ao Excluir!!!";
                repository.cadastra_erro(ex.Message, "Classe ControllerGenerics Excluir NR "+txtRastrear);
                return retorno;
            }
        }


        public T getById(int id)
        {
            return new Repository<T>().Consulta_Id(id);
        }

        public T getById(int id, IRepository<T> repository)
        {
            return repository.Consulta_Id(id);
        }
    }
}
