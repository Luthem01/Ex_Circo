using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Circo
{
    internal class Circo
    {
        public List<Artista> artistas { get; set; } = new List<Artista>();

        public virtual void ListarArtistas()
        {

            foreach (var Art in artistas)
            {
                Console.WriteLine("Nome: {0}", Art.Nome);
                Console.WriteLine("Tempo de apresentação: {0}", Art.TempoApresentacao);
                Console.WriteLine("Inicio de Contrato: {0}", Art.DataInicioContrato);
                Console.WriteLine("Data fim do contrato: {0}", Art.DataFimContrato);

            }
        }

    }
}
