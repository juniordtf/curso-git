﻿using System;
using System.Globalization;

namespace Ex7Cap3.Dominio
{
    public class Acessorio
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public Carro carro { get; set; }

        public Acessorio(string nome, double preco, Carro carro){
            this.nome = nome;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString()
        {
            return nome
                + ", Preço: "
                + preco.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
