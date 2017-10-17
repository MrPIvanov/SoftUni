namespace _08_LogsAggreg
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int logFiles = int.Parse(Console.ReadLine());
            var nameIp = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < logFiles; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                string name = input[1];
                string ip = input[0];
                int time = int.Parse(input[2]);

                var ipTime = new SortedDictionary<string, int>();               //tova e vutre v loopa che da se chisti vseki put


                if (!nameIp.ContainsKey(name))
                {
                    ipTime[ip] = time;
                    nameIp[name] = ipTime;
                }
                else
                {
                    ipTime = nameIp[name];                      //zashto sa tezi dva reda????    - svalqsh infoto za tova ima che da proverim posle
                                                                                                    // ip i vremeto
                    if (ipTime.ContainsKey(ip))
                    {
                        ipTime[ip] += time;                                                         //tuk pravish novite znaniq za vlojeniq dictionary
                    }
                    else
                    {
                        ipTime.Add(ip,time);
                    }

                    //nameIp[name]=ipTime;      //MAU MOJE I BEZ TOZI !!!   //zashto sa tezi dva reda????     // i tuk zapazash novite chasti v glavniq dict
                                                                                                            //poneje posle shte go chistim otnovo(vremenniq)
                }

            }
            foreach (var item in nameIp)
            {
                var allSec = item.Value.Select(x => x.Value).ToList();
                var listOfIps = item.Value.Keys.ToList();                                                       //oburni vnimanie
                Console.WriteLine($"{item.Key}: {allSec.Sum()} [{string.Join(", ", listOfIps)}]");              //na tiq dva reda


            }

        }
    }
}