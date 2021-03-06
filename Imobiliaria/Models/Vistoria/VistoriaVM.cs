﻿using Imobiliaria.Models.Solicitacao;
using System;
using System.Collections.Generic;

namespace Imobiliaria.Models.Vistoria
{
    public class VistoriaVM
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public byte Status { get; set; }
        public DateTime DataFim { get; set; }

        public SolicitacaoVM Solicitacao { get; set; }
        public List<ComodoVM> LstComodo { get; set; }
        public List<MedicaoVM> LstMedicao { get; set; }
    }
}
