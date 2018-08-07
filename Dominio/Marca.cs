using System;
using System.Collections.Generic;

namespace Ex7Cap3.Dominio
{
    public class Marca
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<Carro> carros;

        public Marca(int codigo, string nome, string pais){
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            carros = new List<Carro>();
        }

        public void addCarro(Carro c)
        {
            carros.Add(c);
            carros.Sort();
        }

        public override string ToString()
        {
            return codigo
                + ", "
                + nome
                + ", País: "
                + pais
                + ", Número de carros: "
                + carros.Count;
        }

    }
}
