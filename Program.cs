using System;
using System.Linq;

namespace randomArray
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int[] xArray = new int[random.Next(40, 51)];
      int[] countArray = new int[5];
      
      for(int i = 0; i < xArray.Length; i++){
        int elem = random.Next(1, 6);
        xArray[i] = elem ;

        if (elem == 1) {
          countArray[0]++;
        } else if (elem == 2) {
          countArray[1]++;
        } else if (elem == 3) {
          countArray[2]++;
        } else if (elem == 4) {
          countArray[3]++;
        } else {
          countArray[4]++;
        }
      } 
      
      int num = Array.IndexOf(countArray, countArray.Max()) + 1;
      Console.WriteLine($"Чаще всего встречается число {num}, {countArray.Max()} раз");
    }
  }
}
