﻿using Imobiliaria.Data.Repository;
using Imobiliaria.Helpers;
using Imobiliaria.Service.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Service
{
    public interface IMedicaoService
    {
        //string InserirMedicao(MedicaoVO medicaoVO);
        //IList<MedicaoVO> FindAll();
    }
    public class MedicaoService : IMedicaoService
    {
        #region Injeção

        private readonly IVistoriaRepository _vistoriaRepo;

        public VistoriaService(IVistoriaRepository vistoriaRepository)
        {
            _vistoriaRepo = vistoriaRepository;
        }

        # endregion

        #region Metodos

        public string InserirSolicitacao(SolicitacaoVO solicitacaoVO)
        {
            string resultado = solicitacaoVO.Validar();
            solicitacaoVO.Ativo = true; // alterar para constante
            if (!string.IsNullOrEmpty(resultado))
            {
                return resultado;
            }

            _vistoriaRepo.InserirSolicitacao(solicitacaoVO);
            return null;
        }

        public IList<SolicitacaoVO> FindAll()
        {
            return _vistoriaRepo.FindAll();
        }

        #endregion
    }
}