﻿using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.Util;

namespace ControleDeMedicamentos.ConsoleApp.ModuloPaciente;

public class TelaPaciente : TelaBase<Paciente>, ITelaCrud
{
    public TelaPaciente(IRepositorioPaciente repositorio) : base("Paciente", repositorio)
    {
    }

    public void VisualizarRegistroPorId()
    {
        throw new NotImplementedException();
    }

    protected override void ExibirCabecalhoTabela()
    {
        Console.WriteLine("{0, -10} | {1, -30} | {2, -20} | {3, -20} | {4, -10}", "Id", "Nome", "Telefone", "Cartão SUS", "Requisições");
    }

    protected override void ExibirLinhaTabela(Paciente paciente)
    {
        string requisicoes = "";

        if (paciente.Requisicoes.Count <= 0)
            requisicoes = "Nenhuma";
        else
            requisicoes = string.Join(", ", paciente.Requisicoes.Select(r => r.Id));
 
        Console.WriteLine("{0, -10} | {1, -30} | {2, -20} | {3, -20} | {4, -10}", paciente.Id, paciente.Nome, paciente.Telefone, paciente.Sus, requisicoes);
    }

    protected override Paciente ObterDados()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine()!;

        Console.Write("Digite o telefone: ");
        string telefone = Console.ReadLine()!;

        Console.Write("Digite o número do cartão SUS: ");
        string sus = Console.ReadLine()!;

        Paciente paciente = new Paciente(nome, telefone, sus);
        return paciente;
    }

    public override void EditarRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine($"Editando {nomeEntidade}...");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine();

        VisualizarRegistros(false);

        Console.Write("Digite o ID do registro que deseja selecionar: ");
        int idRegistro = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Paciente registroEditado = ObterDados();

        string erros = registroEditado.Validar();

        if (erros.Length > 0)
        {
            Notificador.ExibirMensagem(erros, ConsoleColor.Red);

            EditarRegistro();

            return;
        }

        foreach (Paciente registro in repositorio.SelecionarRegistros())
        {
            if (registro.Sus == registroEditado.Sus)
            {
                Notificador.ExibirMensagem("Cartão Sus já existente", ConsoleColor.Red);

                return;
            }
        }

        bool conseguiuEditar = repositorio.EditarRegistro(idRegistro, registroEditado);

        if (!conseguiuEditar)
        {
            Notificador.ExibirMensagem("Houve um erro durante a edição do registro...", ConsoleColor.Red);

            return;
        }

        Notificador.ExibirMensagem("O registro foi editado com sucesso!", ConsoleColor.Green);
    }

}
