using System;
using System.Linq;

namespace LAB_3_5_DANABRIDGES
{
    class Program
    {
        static void Main(string[] args)
        {
            string blacklist = "follow me";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blacklist))
            {
                isSpam = true;
                Console.WriteLine("this is spam");
            }

            else
            {
                isSpam = false;
                Console.WriteLine("this isnt spam");


            }


            



            
          
           
                   
           
           
          
           
            

            
            
                
            

                 




        }
 
    }
}
git remote add origin https://github.com/enocpi/mygithub.git
git push -u origin maste

