﻿using System;

namespace Imobiliaria.Models.Solicitacao
{
    public class ViewSolicitacaoVM
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataVistoria { get; set; }
        public string IdSolicitador { get; set; }
        public string IdVistoriador { get; set; }
        public byte Status { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string NomeProprietario { get; set; }
        public string NomeVistoriador { get; set; }

    }
}
