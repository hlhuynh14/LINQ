using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class LINQQuestions
    {// member variables (HAS A)
     // constructors
     // member methods (CAN DO)
      public List<string> ReturnTHOfList( List<string> list)
      {

            List<string> thList = list.Where(l => l.Contains("th")).ToList();
            return thList;
            
      }
        public List<string> GetNames( List<string> list)
        {
            List<string> namesList = list.Distinct().ToList();
            return namesList;
        }
        public double GetAverage(List<string> list)
        {

            List<double> numberList4 = new List<double>();
            foreach (string element in list)
            {

                List<string> numberList;
                numberList = element.Split(',').ToList();
                List<int> numberList2 = new List<int>();
                foreach ( string elements in numberList)
                {
                    numberList2.Add(Int32.Parse(elements));
                }
                var numberList3 = from number in numberList2
                                        where number > numberList2.Min()
                                             select number;
               double average = numberList3.Average();
                numberList4.Add(average);
                
            }
            double average2 = numberList4.Average();
            return average2;
        }
        public void AlphabetFrequency(string word)
        {
            string words = word.Trim();
            string newwords = word.Replace(" ", "");
            var frequencies = from letter in newwords.ToArray()
                              orderby letter
                              group letter by letter into letterfrequencies
                              select letterfrequencies;
            string newstring = "";
            foreach (var letter in frequencies)
            {
               newstring += ($"{letter.Key}{letter.Count()}");
            }
            Console.WriteLine(newstring);
            Console.ReadLine();

        }

    }
}
