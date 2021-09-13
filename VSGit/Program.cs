using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSGit
{
  class Program
  {
    static void Main(string[] args)
    {
      ElsoFeladat();
            MasodikFeladat();
      Console.ReadKey();
    }

        private static void MasodikFeladat()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 101);
            Console.WriteLine(x);
        }

        private static void ElsoFeladat()
    {
      Console.WriteLine("Próba");
    }
  }
}
