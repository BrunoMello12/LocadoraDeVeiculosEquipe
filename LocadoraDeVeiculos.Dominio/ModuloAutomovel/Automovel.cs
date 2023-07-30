using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel
{
    public class Automovel : EntidadeBase<Automovel>
    {
        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Cor { get; set; }

        public string Modelo { get; set; }

        public TipoCombustivelEnum TipoCombustivel { get; set; }

        public decimal CapacidadeLitros { get; set; }

        public int Ano { get; set; }

        public GrupoAutomoveis GrupoDoAutomovel { get; set; }

        public Automovel(string placa, string marca, string cor, string modelo, TipoCombustivelEnum tipoCombustivel, decimal capacidadeLitros, int ano)
        {
            Placa = placa;
            Marca = marca;
            Cor = cor;
            Modelo = modelo;
            TipoCombustivel = tipoCombustivel;
            CapacidadeLitros = capacidadeLitros;
            Ano = ano;
        }

        public override void Atualizar(Automovel registro)
        {
            Placa = registro.Placa;
            Marca = registro.Marca;
            Cor = registro.Cor; 
            Modelo = registro.Modelo;
            TipoCombustivel = registro.TipoCombustivel;
            CapacidadeLitros = registro.CapacidadeLitros;
            Ano = registro.Ano;
        }
    }
}
