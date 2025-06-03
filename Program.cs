using encapsulation_poo_curso_csharp.Exercicio_01;
using encapsulation_poo_curso_csharp.Exercicio_02;
using encapsulation_poo_curso_csharp.Exercicio_03;
using encapsulation_poo_curso_csharp.Exercicio_04;
using encapsulation_poo_curso_csharp.Exercicio_05;
using encapsulation_poo_curso_csharp.Exercicio_06;
using encapsulation_poo_curso_csharp.Exercicio_07;
using encapsulation_poo_curso_csharp.Exercicio_08;
using encapsulation_poo_curso_csharp.Exercicio_09;
using encapsulation_poo_curso_csharp.Exercicio_10;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Veiculo veiculo = new Veiculo("ABC-1234");
        veiculo.AtualizarVelocidade(72.5);
        Console.WriteLine($"Veículo: {veiculo.Placa}");
        Console.WriteLine($"Velocidade atual: {veiculo.VelocidadeAtual} Km/h");

        Console.WriteLine("----------------------------------------------------------------");

        Avaliacao avaliacao = new Avaliacao("Carla Silva");
        avaliacao.AtribuirNota(11);
        avaliacao.AtribuirNota(8.5);
        Console.WriteLine($"Aluno: {avaliacao.Aluno}");
        Console.WriteLine($"Nota atribuída: {avaliacao.Nota}");

        Console.WriteLine("----------------------------------------------------------------");

        Paciente paciente = new Paciente("Luiz Costa", 42);
        HistorioMedico historico = new HistorioMedico("XPT-9987");
        historico.ExibirCodigo();

        Console.WriteLine("----------------------------------------------------------------");

        Funcionario funcionario = new Funcionario("Fernanda Lima", 4000);
        funcionario.ReajustarSalario(3500);
        funcionario.ReajustarSalario(4200);
        Console.WriteLine($"Funcionário: {funcionario.Nome}");
        Console.WriteLine($"Salário atual: R${funcionario.Salario.ToString("F2")}");

        Console.WriteLine("----------------------------------------------------------------");

        Projeto projeto = new Projeto("Sistema de Inventário");
        projeto.AdicionarTarefa("Criar tela de login");
        projeto.AdicionarTarefa("Implementar banco de dados");
        projeto.ExibirTarefas();

        Console.WriteLine("----------------------------------------------------------------");

        ContaBancaria conta = new ContaBancaria("123456", 1000);
        conta.Sacar(1500);
        conta.Sacar(0);
        conta.Sacar(500);

        Console.WriteLine("----------------------------------------------------------------");

        Agenda agenda = new Agenda("Marina Souza");
        agenda.AdicionarContato(new Contato("Joao", "123456789"));
        agenda.AdicionarContato(new Contato("Joao", "123456789"));
        agenda.AdicionarContato(new Contato("Maria", "123456789"));
        agenda.ListarContatos();

        Console.WriteLine("----------------------------------------------------------------");

        Estudante estudante = new Estudante("Lucas Rocha");
        estudante.Nota1 = 7.5;
        estudante.Nota2 = 5.0;
        Console.WriteLine($"Estudante: {estudante.Nome}");
        Console.WriteLine($"Média: {estudante.Media.ToString("F2")}");
        Console.WriteLine($"Situação: {estudante.Situacao}");

        Console.WriteLine("----------------------------------------------------------------");

        Curso curso = new Curso("Programação C#", 2);
        curso.Matricular(new Estudante_Exercicio_09("Ana Paula"));
        curso.Matricular(new Estudante_Exercicio_09("Joao"));
        curso.Matricular(new Estudante_Exercicio_09("Mirela"));
        curso.ListarMatriculados();
        Console.WriteLine($"Vagas disponíveis: {curso.VagasDisponiveis}");

        Console.WriteLine("----------------------------------------------------------------");

        Hospede hospede = new Hospede("Carlos Silva");
        Quarto quarto = new Quarto(101);
        quarto.ValorDiaria = 150.00;
        Reserva reserva = new Reserva(hospede, quarto, 3);

        Console.WriteLine($"Reserva para {reserva.Hospede.Nome}");
        Console.WriteLine($"Quarto: {reserva.Quarto.Numero}");
        Console.WriteLine($"Valor total da reserva: R${reserva.ValorTotal.ToString("F2")}");

    }
}