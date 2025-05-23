﻿using ControleDeMedicamentos.ConsoleApp.Compartilhado;

namespace ControleDeMedicamentos.ConsoleApp.ModuloRequisicaoDeEntrada
{
    public class RepositorioRequisicaoDeEntradaEmArquivo : RepositorioBaseEmArquivo<RequisicaoDeEntrada>, IRepositorioRequisicaoDeEntrada
    {
        public RepositorioRequisicaoDeEntradaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<RequisicaoDeEntrada> ObterRegistros()
        {
            return contexto.RequisicoesDeEntrada;
        }
        protected override bool VerificarRegistroExistente(RequisicaoDeEntrada registro)
        {
            return false;
        }
    }
}
