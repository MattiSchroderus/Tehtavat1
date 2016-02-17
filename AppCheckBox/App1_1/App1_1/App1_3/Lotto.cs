using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1_3
{
    class Lotto
    {
        public string Result { get; set; }
        public int Row { get; set; }
      public int Greatestnumber { get; set; }

      

        public Lotto(int row, int greatestnumber, string result)
        {
            Row = row;
            Greatestnumber = greatestnumber;
            Result = result;
        }



        public void PerusLotto()
        {
           
            Random rand = new Random();
            
            while (Row > 0)
            {
                int number = rand.Next(1, Greatestnumber + 1);
                Result += number + " ";
                Row--;
            }
            
        }

       

         

    }
}

