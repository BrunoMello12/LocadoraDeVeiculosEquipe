using LocadoraDeVeiculos.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloParceiro
{
    public class Parceiro : EntidadeBase<Parceiro>
    {
        public string Nome { get; set; }

        public Parceiro(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override void Atualizar(Parceiro registro)
        {
            Nome = registro.Nome;
        }
    }
}
