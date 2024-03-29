﻿using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCobranca;

namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis
{
    public class GrupoAutomoveis : EntidadeBase<GrupoAutomoveis>
    {
        public string Nome { get; set; }

        public List<Automovel> listaDeAutomoveis { get; set; }

        public List<Cobranca> listaDeCobrancas { get; set; }

        public GrupoAutomoveis()
        {
            
        }

        public GrupoAutomoveis(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
            listaDeAutomoveis = new List<Automovel>();
        }

        public override void Atualizar(GrupoAutomoveis registro)
        {
            Nome = registro.Nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
