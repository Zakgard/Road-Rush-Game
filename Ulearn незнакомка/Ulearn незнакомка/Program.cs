using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn_незнакомка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<string>();

            contacts.Add("Sasha:sasha@gmail.com");
            contacts.Add("Sancho:sancho@mail.ru");
            contacts.Add("Roma:roma@gmail.com");
            contacts.Add("Gusein:gusein@mail.com");
            contacts.Add("G:gusein@mail.com");
            contacts.Add(":");
         //   contacts.Add("");
            contacts.Add("Gusein:");
            contacts.Add("Gu:gusein@mail.com");
            contacts.Add("G:gusein@mail.com");
            contacts.Add("Roma:4567@gmail.com");
            contacts.Add("Sasha:sa@gm.com");
            contacts.Add(":gusein@mail.com");
            contacts.Add("Roma:");
           // contacts.Add($"{null}:sa@gm.com:priz@rty.com");
           // contacts.Add($"{null}:{null}");
            contacts.Add($"Sasha:{null}");
            contacts.Add(":gusein@mail.com");
            contacts.Add("Roma:");

            Console.WriteLine(OptimizeContacts(contacts));
            Console.ReadKey();
        }

        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            Dictionary<string, List<string>> dictionary=new Dictionary<string, List<string>>();
            List<string> keysList=new List<string>();
            List<string> tempValues=new List<string>();
            string tempValue;
            List<int> ints=new List<int>();
            for (int i=0; i<contacts.Count; i++)
            {                
                string tempKey= contacts[i].Split(':').ToArray()[0];
                if (tempKey.Length > 2)
                {
                    tempKey.Remove(2);
                }
                for (int j=0; j< contacts.Count; j++)
                {
                    if (contacts[i].Split(':').Length > 2)
                    {
                        for(int k=2; k< contacts[i].Split(':').Length; k++)
                        {
                            ints.Add(k);
                        }
                    }
                    for(int k=1; k< ints.Count+2; k++)
                    {
                       tempValue = contacts[i].Split(':').ToArray()[k];
                       if(tempValue.Contains(tempKey))
                           tempValues.Add(tempValue);
                    }
                    ints.Clear();
                }                
                if (dictionary.ContainsKey(tempKey))
                    break;
                else
                    dictionary.Add(tempKey, tempValues);

                tempValues.Clear();
            }

            return dictionary;
        }  
    }
}
