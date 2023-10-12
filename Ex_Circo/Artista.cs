using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Circo
{
    internal class Artista
    {
        public string Nome { get; set; }
        public TimeOnly TempoApresentacao { get; set; }
        public DateOnly DataInicioContrato { get; set; }
        public DateOnly DataFimContrato { get; set; }

        public bool Ativo {  get; set; }
      
        public Artista() { }

        public Artista(string nome, TimeOnly TempoApresentacao, DateOnly DataInicioContrato, DateOnly DataFimContrato)
        {
            this.Nome = nome;
            this.TempoApresentacao = TempoApresentacao;
            this.DataInicioContrato = DataInicioContrato;
            this.DataFimContrato = DataFimContrato;
            
        }

        public void AtivarDesativarArtista()
        {
            Console.WriteLine("Digite o nome que deseja realizar a alteração");
            Nome = Console.ReadLine();
            
            Console.WriteLine("Para inativar o artista digite: 0\n Para ativar o artista digite: 1");
            int ativo = int.Parse(Console.ReadLine());
            try
            {
                if (ativo == 1)
                {
                    Ativo = true;
                    Console.WriteLine("Artista: {0},", (Nome) + " foi ativado com sucesso!");

                }
                else if (ativo == 0) 
                {
                    Ativo = false;
                    Console.WriteLine("Artista: {0},", (Nome) + " foi desligado!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Opção inválida");
            }
        }
        //virtual - classe pai
        //override - classe filho
        public virtual void CadastroArtista()
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

        public virtual void ImprimeHabilidades()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(TempoApresentacao);
        }

    }

}



