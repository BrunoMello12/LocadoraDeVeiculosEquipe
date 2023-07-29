using LocadoraDeVeiculos.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis
{
    public class GrupoAutomoveis : EntidadeBase<GrupoAutomoveis>
    {
        public string Nome { get; set; }

        public GrupoAutomoveis(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override void Atualizar(GrupoAutomoveis registro)
        {
            Nome = registro.Nome;
        }
    }
}
