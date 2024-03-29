﻿using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;

namespace LocadoraDeVeiculos.Dominio.ModuloCupom
{
    public class Cupom : EntidadeBase<Cupom>
    {
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataValidade { get; set; }

        public Parceiro Parceiro { get; set; }

        public List<Cliente> ClientesJaUtilizados { get; set; }

        public Cupom()
        {
            
        }

        public Cupom(string nome, decimal valor, DateTime dataValidade, Parceiro parceiro, List<Cliente> clientesJaUtilizados)
        {
            Nome = nome;
            Valor = valor;
            DataValidade = dataValidade;
            Parceiro = parceiro;
            ClientesJaUtilizados = clientesJaUtilizados;
        }

        public override void Atualizar(Cupom registro)
        {
            Nome = registro.Nome;
            Valor = registro.Valor;
            DataValidade = registro.DataValidade;
            Parceiro = registro.Parceiro;
        }
    }
}
