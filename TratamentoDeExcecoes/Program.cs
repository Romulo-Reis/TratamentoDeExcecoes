using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoDeExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Venda venda = new Venda
            {
                Id = 1,
                Data = DateTime.Today
            };

            ItemVenda item1 = new ItemVenda
            {
                Descricao = "Smartphone",
                Preco = 2000,
                Quantidade = 1
            };

            ItemVenda item2 = null;

            try
            {
                venda.AdicionarItem(item1);
                //venda.AdicionarItem(item2);
                Console.WriteLine(venda.CalcularTotal());
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (VendaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Processamento concluído");
            }
            Console.ReadKey();
        }
    }
}
