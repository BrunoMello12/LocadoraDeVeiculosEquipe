using FluentValidation;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel
{
    public class ValidadorAutomovel : AbstractValidator<Automovel>, IValidadorAutomovel
    {
        public ValidadorAutomovel()
        {
            //RuleFor(x => x.GrupoDoAutomovel)
            //    .NotNull().NotEmpty();

            //RuleFor(x => x.Modelo)
            //        .NotNull().NotEmpty();

            //RuleFor(x => x.Marca)
            //        .NotNull().NotEmpty();

            //RuleFor(x => x.Cor)
            //        .NotNull().NotEmpty();

            //RuleFor(x => x.TipoCombustivel)
            //        .NotNull().NotEmpty();

            //RuleFor(x => x.CapacidadeLitros)
            //        .NotNull().NotEmpty();

            RuleFor(x => x.GrupoDoAutomovel)
                .NotNull().WithMessage("O Grupo do Automóvel deve ser informado.");

            RuleFor(x => x.Modelo)
                .NotNull().NotEmpty().WithMessage("O Modelo do Automóvel deve ser informado.");

            RuleFor(x => x.Marca)
                .NotNull().NotEmpty().WithMessage("A Marca do Automóvel deve ser informada.");

            RuleFor(x => x.Cor)
                .NotNull().NotEmpty().WithMessage("A Cor do Automóvel deve ser informada.");

            RuleFor(x => x.TipoCombustivel)
                .NotNull().WithMessage("O Tipo de Combustível do Automóvel deve ser informado.");

            RuleFor(x => x.CapacidadeLitros)
                .NotNull().WithMessage("A Capacidade em Litros do Automóvel deve ser informada.");

            //RuleFor(x => x)
            //    .Must((automovel) => VerificarDisponibilidade(automovel)).WithMessage("O veículo não está disponível para aluguel.");

            //RuleFor(x => x)
            //    .Must((automovel) => VerificarDocumentosEmDia(automovel)).WithMessage("Os documentos do veículo não estão em dia.");
        }

        //private bool VerificarDisponibilidade(Automovel automovel)
        //{
        //    List<Automovel> automoveisAlugados = new List<Automovel>();
            
        //    foreach(Aluguel a in IRepositorioAluguel.SelecionarTodos())
        //    {
        //        automoveisAlugados.Add(a.Automovel);
        //    }

        //    if(automoveisAlugados.Contains(automovel))
        //    // Implementar a lógica para verificar se o veículo está disponível para aluguel
        //    // Pode ser necessário acessar um banco de dados ou outro mecanismo de armazenamento de dados.
        //    // Retornar true se o veículo estiver disponível e false caso contrário.
        //    // Exemplo de implementação:
        //    // return VerificarDisponibilidadeNoBancoDeDados(automovel.Id);
        //    return true;
        //}

        //private bool VerificarDocumentosEmDia(Automovel automovel)
        //{
        //    // Implementar a lógica para verificar se os documentos do veículo estão em dia
        //    // Pode ser necessário acessar um banco de dados ou outro mecanismo de armazenamento de dados.
        //    // Retornar true se os documentos estiverem em dia e false caso contrário.
        //    // Exemplo de implementação:
        //    // return VerificarDocumentosEmDiaNoBancoDeDados(automovel.Id);
        //    return true;
        //}
    }
}
