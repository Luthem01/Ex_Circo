using Ex_Circo;
using System;

namespace Circus
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Artista artista = new("Pedro", new TimeOnly(0, 10, 0), new DateOnly(2023, 03, 10), new DateOnly(2024, 03, 10));
            Circo circo = new Circo();
            
            Equilibrista equilibrista = new Equilibrista();
            Malabarista malabarista = new Malabarista();
            Palhaco palhaco = new Palhaco();
            Artista artista = new Artista();
            //artista.CadastroArtista();
            //circo.artistas.Add(artista);
            ////equilibrista.CadastroArtista();
            //malabarista.CadastroArtista();
            //palhaco.CadastroArtista();

            Console.WriteLine("Digite 1 para: Cadastrar Equilibrista.");
            Console.WriteLine("Digite 2 para: Cadastrar Malabarista.");
            Console.WriteLine("Digite 3 para: Cadastrar Palhaço.");
           switch (Console.ReadLine())
                {
                    case "1":
                        {
                            equilibrista.CadastroArtista();
                            circo.artistas.Add(equilibrista);
                            equilibrista.ImprimeHabilidades();
                        }
                        break;
                    case "2":
                        {
                            malabarista.CadastroArtista();
                            circo.artistas.Add(malabarista);
                            malabarista.ImprimeHabilidades();

                        }
                        break;
                    case "3":
                        {
                            palhaco.CadastroArtista();
                            circo.artistas.Add(palhaco);
                            palhaco.ImprimeHabilidades();
                        }
                        break;

                }
            

           
            //circo.ListarArtistas();
            //palhaco.ImprimeHabilidades();
            //equilibrista.ImprimeHabilidades();
            //malabarista.ImprimeHabilidades();
          

            //artista.CadastroArtista();
            //artista.ListarArtistas();

            //artista.AtivarDesativarArtista();
          
            
        }
    }
    
}