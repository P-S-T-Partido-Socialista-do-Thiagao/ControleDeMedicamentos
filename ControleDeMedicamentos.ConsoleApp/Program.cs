﻿using ControleDeMedicamentos.ConsoleApp.Compartilhado;

namespace ControleDeMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            while (true)
            {
                telaPrincipal.ApresentarMenuPrincipal();

                ITelaCrud telaSelecionada = telaPrincipal.ObterTela();

                char opcaoEscolhida = telaSelecionada.ApresentarMenu();

                if (opcaoEscolhida == 'S' || opcaoEscolhida == 's')
                    break;

                switch (opcaoEscolhida)
                {
                    case '1':
                        telaSelecionada.CadastrarRegistro();
                        break;
                    case '2':
                        telaSelecionada.EditarRegistro();
                        break;
                    case '3':
                        telaSelecionada.ExcluirRegistro();
                        break;
                    case '4':
                        telaSelecionada.VisualizarRegistros(true);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
