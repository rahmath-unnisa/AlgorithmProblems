using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems.Utility
{
    public class MessageDemonstration
    { 
        public void Message()
            {
                string message = "Hello <<name>>, We have your full name as << full name >> in our system. your contact number is 91 - xxxxxxxxxx.Please,let us know in case of any clarification Thank you BridgeLabz 01 / 01 / 2016.";
                Console.WriteLine(message);
                Console.WriteLine("Enter the name: ");
                string name1 = Console.ReadLine();
                Console.WriteLine("Enter the full name: ");
                string name2 = Console.ReadLine();
                Console.WriteLine("Enter the Mobile Number: ");
                string mobile = Console.ReadLine();
                message = message.Replace("<<name>>", name1).Replace("<< full name >>", name2);
                message = message.Replace("xxxxxxxxxx", mobile).Replace("01 / 01 / 2016", "07 / 05 / 2022");
                Console.WriteLine(message);
            }
        }
    }

