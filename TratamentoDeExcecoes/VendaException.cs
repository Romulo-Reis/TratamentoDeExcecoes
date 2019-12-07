using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoDeExcecoes
{
    public class VendaException : Exception
    {
        public int Codigo { get; set; }
        public VendaException(int codigo, string mensagem) : base($"{ mensagem}. Código do erro: {codigo}")
        {

        }
    }
}
