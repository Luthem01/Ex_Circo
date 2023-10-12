using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Circo
{
    internal class Malabarista : Artista
    {
        public int malabares;
        public int bolinhas;
        public int facas;

        public Malabarista() { }
        public Malabarista(string nome, TimeOnly TempoApresentacao, DateOnly DataInicioContrato, DateOnly DataFimContrato, int malabares, int bolinhas, int facas ) : base(nome, TempoApresentacao, DataInicioContrato, DataFimContrato)
        {
            this.Nome = nome;
            this.TempoApresentacao = TempoApresentacao;
            this.DataInicioContrato = DataInicioContrato;
            this.DataFimContrato = DataFimContrato;
            this.malabares = malabares;
            this.bolinhas = bolinhas;
            this.facas = facas;
        }

        public override void ImprimeHabilidades()
        {
            Console.WriteLine("Nome: {0}",Nome);
            Console.WriteLine("duração de apresentação: {0}",TempoApresentacao);
            Console.WriteLine("Quantidade de malabares: {0}",malabares);
            Console.WriteLine("Quantidade de bolinhas: {0}", bolinhas);
            Console.WriteLine("Quantidade de facas: {0}", facas);
        }
        public override void CadastroArtista()
        {
            Console.WriteLine("Digite o nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual o tempo de apresentação?");
            TempoApresentacao = TimeOnly.Parse(Console.ReadLine());
            Console.WriteLine("Data de inicio de contrato: ");
            DataInicioContrato = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Data do fim do contrato: ");
            DataFimContrato = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Quantas malabares para a apresentação?");
            malabares = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos bolinhas para a apresentação?");
            bolinhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas facas para a apresentação?");
            facas = int.Parse(Console.ReadLine());

        }

    }
}
