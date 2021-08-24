using System;
using System.Text;

namespace BelajarGenerate
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int counter = 10982;

         string output = GenerateInVoice(counter);
         Console.WriteLine(output);
          
           
        }
         
       static String GenerateInVoice(int counter)
            {

                DateTime now = DateTime.Now;
                int day = Convert.ToInt32(now.Day);
                String month = Convert.ToString(now.Month);
                String year = Convert.ToString(now.Year);
                String dayName = System.DateTime.Now.DayOfWeek.ToString();
                dayName = dayName.ToUpper().Substring(0, 2);
                int yearInt = Convert.ToInt32(year.Substring(2, 2));
                


                if (month.Length == 1)
                {
                    month = $"0{month}";
                }
                //Console.WriteLine(month);
                //localized version
                //System.DateTime.Now.ToString("dddd");

                String name = $"INV/{year}{month}/{dayName}/{GetRomawi(day)}/{GetRomawi(yearInt)}/{++c}";

                return name;
            }


        }




 }

