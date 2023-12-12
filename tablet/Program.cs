using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablet
{
    internal class Program
    {
        class tablet
        {
            private string[] marca=new string[5];
            private double[] velocità=new double[5];
            private double[] dimensione = new double[5];
            private double[] batteria = new double[5];
            private double[] voti=new double[5];

            public void leggiDati()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Inserisic la marca del tablet");
                    marca[i] = Console.ReadLine();
                    Console.WriteLine("Inserisic la velocità (espressa in GHz) del tablet");
                    velocità[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisic la dimensione dello schermo (espresso in pollici) del tablet");
                    dimensione[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisic la durata della batteria (espressa in mAh, milliampere-ora) del tablet");
                    batteria[i] = double.Parse(Console.ReadLine());
                }
            }

            public void scriviDati()
            {
                for(int i = 0;i < 3;i++)
                {
                    Console.WriteLine("Marca: "+marca[i]);
                    Console.WriteLine("Velocità: " + velocità[i]+"GHz");
                    Console.WriteLine("Dimensione: " + dimensione[i]+"pollici");
                    Console.WriteLine("Batteria: " + batteria[i]+"mAH");
                }
            }

            public void votiCalcola()
            {
                int v = 0,d=0,b=0;
                for( int i = 0; i<1; i++)
                {
                    v = Convert.ToInt32(velocità[i]*10);
                    d = Convert.ToInt32(dimensione[i]);
                    b = Convert.ToInt32(batteria[i]/1000);
                    voti[i] = (v+d+b)/3;
                }
            }

            public void mP()
            {
                double m = voti[0], p = voti[0];
                int r = 0, r1 = 0;
                for( int i = 0; i<3; i++) 
                {
                    if (m > voti[i+1])
                    {
                        m = voti[i];
                        r = i;
                    }
                    if (p < voti[i+1])  
                    {
                        p = voti[i];
                        r1 = i;
                    }
                }
                Console.WriteLine("Il migliore è:" + marca[r]+"\nIl peggiore è: "+marca[r1]); 
            }

        }
        static void Main(string[] args)
        {
            tablet tablet = new tablet();
            tablet.leggiDati();
            tablet.scriviDati();
            tablet.votiCalcola();
            tablet.mP();
            Console.ReadLine();
        }
    }
}
