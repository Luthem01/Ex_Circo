using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Circo
{
    internal class Equilibrista : Artista
    {

        public int caixa;
        public int bastao;
        public int bola;
        public Equilibrista()
        {

        }
        public Equilibrista(string nome, TimeOnly TempoApresentacao, DateOnly DataInicioContrato, DateOnly DataFimContrato, int bola, int bastao, int caixa) : base(nome, TempoApresentacao, DataInicioContrato, DataFimContrato)
        {
            this.Nome = nome;
            this.TempoApresentacao = TempoApresentacao;
            this.DataInicioContrato = DataInicioContrato;
            this.DataFimContrato = DataFimContrato;
            this.caixa = caixa;
            this.bastao = bastao;
            this.bola = bola;
        }
              

        public override void ImprimeHabilidades()
        {
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("duração de apresentação: {0}", TempoApresentacao);
            Console.WriteLine("Quantidade de caixa: {0}", caixa);
            Console.WriteLine("Quantidade de bastao: {0}", bastao);
            Console.WriteLine("Quantidade de bola: {0}", bola);
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
            Console.WriteLine("Quantas caixas para a apresentação?");
            caixa = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos bastões para a apresentação?");
            bastao = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas bolas para a apresentação?");
            bola = int.Parse(Console.ReadLine());
            
        }

    }
}
