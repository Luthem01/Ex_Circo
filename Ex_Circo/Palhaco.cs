using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Circo
{
    internal class Palhaco : Artista
    {
        
        public Palhaco() { }
        public Palhaco(string nome, TimeOnly TempoApresentacao, DateOnly DataInicioContrato, DateOnly DataFimContrato): base(nome,TempoApresentacao,DataInicioContrato,DataFimContrato)
        {
            this.Nome = nome;
            this.TempoApresentacao = TempoApresentacao;
            this.DataInicioContrato = DataInicioContrato;
            this.DataFimContrato = DataFimContrato;
        }

        public override void ImprimeHabilidades()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(TempoApresentacao);
            Console.WriteLine("Apresentação especial em criação!!");
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
            
        }

    }
}
