using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CifradeCesar
{
    public class CripDescrip
    {
        public string cripTo (string texto1)
        {
                    string texto2 = "";
                    int numCar = texto1.Length;
                    
                    for(int i = 0; i < numCar; i++)
                    {
                      int num = Convert.ToInt32(texto1[i] + 3);
                      texto2 += Convert.ToChar(num);
                    }

                   return texto2;
                    
        }

        public string deCripto (string texto1)
        {
            string texto2 = "";
                    int numCar = texto1.Length;
                    
                    for(int i = 0; i < numCar; i++)
                    {
                      int num = Convert.ToInt32(texto1[i] - 3);
                      texto2 += Convert.ToChar(num);
                    }

                   return texto2;
        }
    }
}