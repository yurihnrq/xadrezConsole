﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tabuleiro {
    class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            quantidadeMovimentos = 0;
        }

    }
}