using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalent.Services
{
    public class Calculadora
    {
        private List<string> listhistorico;
        private string data;

        public Calculadora(string data)
        {
            listhistorico = new List<string>();
            this.data = data;
        }
        
        
        public int Somar(int val1, int val2)
        {
            listhistorico.Insert(0, $"{val1} + {val2} = {val1 + val2}, data = {data}");
            return val1 + val2;
        }

        public int Subtrair(int val1, int val2)
        {
            listhistorico.Insert(0, $"{val1} + {val2} = {val1 - val2}");
            return val1 - val2;
        }

        public int Multiplicar(int val1, int val2)
        {
            listhistorico.Insert(0, $"{val1} + {val2} = {val1 * val2}");
            return val1 * val2;
        }

        public int Dividir(int val1, int val2)
        {
            listhistorico.Insert(0, $"{val1} + {val2} = {val1 / val2}");
            return val1 / val2;
        }

        public List<string> Historico()
        {
            listhistorico.RemoveRange(3, listhistorico.Count - 3);
            return listhistorico;
        }
    }
}