using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LINQ_Assignment
{
    public class student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string smailid { get; set; }
        public string branch { get; set; }
        public double per { get; set; }
    }
    class Assignment1
    {
        static void Main(string[] args)
        {
            {
                List<student> Slist = new List<student>()
                {

                    new student() { firstname = "Roy", lastname = "Singh", smailid = "roysingh@gmail.com", branch = "CS",per=65},
                    new student() { firstname = "Sam", lastname = "Thakur", smailid = "samthakur@gmail.com", branch = "IT" ,per=75},
                    new student() { firstname = "Pratik", lastname = "Hepat", smailid = "pratikhepat@gmail.com", branch = "IT",per=80 },
                    new student() { firstname = "Sandeep", lastname = "Potdhuke", smailid = "sandeeppotdhuke@gmail.com", branch = "CS",per=85 },
                    new student() { firstname = "Akshat", lastname = "Keoliya", smailid = "akshatkeoliya@gmail.com", branch = "IT",per=81 },
                    new student() { firstname = "Pradeep", lastname = "Mahur", smailid = "pradeepmahur@gmail.com", branch = "CS",per=77 },


                };
                Console.WriteLine("All OPERATIONS IN LINQ");
                Console.WriteLine("----------SELECT-----------");
                var query = (from i in Slist select i);
               
                
                foreach (var i in query)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.smailid + "," + i.branch + "," + i.per);
                }
             
            
                Console.WriteLine("---------WHERE------------");
             
                var query1 = (from i in Slist where i.per > 75 select i);
               
                foreach (student i in query1)
                {
                    Console.WriteLine(i.firstname);
                }
               
                Console.WriteLine("---------TAKE------------");
                Console.WriteLine("Taking top 3 items in the list");
                var query2 = Slist.Select(i => i).Take(3);
           
                foreach (var i in query2)
                {
                    Console.WriteLine(i.per);
                }
                
                Console.WriteLine("\n------------TakeWhile query-------------");
                Console.WriteLine("Taking the items until the firstname==Pradeep\n");
                var query3 = Slist.TakeWhile(i => i.firstname == "Pradeep");
                foreach (var i in query3)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + ","+ i.branch + "," + i.per);
                }
                Console.WriteLine("----------SKIP-----------");
                Console.WriteLine("Skipping first 2 items in the list\n");
                var query4 = Slist.Skip(2);
                foreach (var i in query4)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.branch + "," + i.per);
                }
                
                Console.WriteLine("----------SKIPWHILE-----------");
                var query5 = Slist.SkipWhile(i => i.per>77);

                foreach (var i in query5)
                {
                    Console.WriteLine( i.per);
                }
                Console.WriteLine("----------ORDERBY ASC-----------");
                var query6 = from i in Slist orderby i.firstname ascending select i;

                foreach (var i in query6)
                {
                    Console.WriteLine(i.firstname);
                }
                Console.WriteLine("----------ORDERBY DSC-----------");
                var query7 = from i in Slist orderby i.firstname descending select i;
               
               
                foreach (var i in query7)
                {
                    Console.WriteLine(i.firstname);
                }
               
               
                Console.WriteLine("----------GROUPBY-----------");
                var query8 = Slist.GroupBy(i => i.per < 85);

                foreach (var group in query8)
                {
                    Console.WriteLine(group.Key);
                    foreach (var i in group)
                    {
                        Console.WriteLine(i.per);
                    }

                }

                Console.WriteLine("---------SELECT------------");
                var query9 = (from i in Slist select i.per);


                foreach (var i in query)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.branch + "," + i.per);
                }


                List<List<int>> arr = new List<List<int>>();
                List<int> arrIn = new List<int> { 1, 2, 3, 4, 5 };
                arr.Add(arrIn);
                Console.WriteLine("\n-------------SelectMany query-----------------");
                Console.WriteLine("Quering a list of lists using SelectMany\n");
                var query10 = arr.SelectMany(i => i);
                foreach (var i in query10)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("-------------Aggregate Functions---------------");

                Console.WriteLine("\n1.Sum of all per");
                var query11 = Slist.Sum(i => i.per);
                Console.WriteLine(query11);

                Console.WriteLine("\n2.Max of per");
                var query12 = Slist.Max(i => i.per);
                Console.WriteLine(query12);

                Console.WriteLine("\n3.Min of per");
                var query13 = Slist.Min(i => i.per);
                Console.WriteLine(query13);

                Console.WriteLine("\n4.Avg of per");
                var query14 = Slist.Average(i => i.per);
                Console.WriteLine(query14);

                Console.WriteLine("\n5.Count of per<85");
                var query15 = Slist.Count(i => i.per < 85);
                Console.WriteLine(query15);

                Console.WriteLine("\n6.Distinct");
                Console.WriteLine("All the distinct items of the list1 array");
                List<int> list1 = new List<int>() { 1, 1, 2, 2, 3, 4, 5 };
                List<int> list2 = new List<int>() { 1, 1, 2, 2, 5, 6, 7 };
                var query16 = list1.Distinct();
                foreach (var i in query16)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("-----------Let Query---------------");
                Console.WriteLine("Changing the values of the list1 items by adding some numbers to it");
                var query17 = from i in list1 let res = i + 20 select res;
                foreach (var i in query17)
                {
                    Console.WriteLine(i);
                }
                List<student> Slist2 = new List<student>()
                {

                    new student() { firstname = "Roy", lastname = "Singh", smailid = "roysingh@gmail.com", branch = "CS",per=65},
                    new student() { firstname = "Sam", lastname = "Thakur", smailid = "samthakur@gmail.com", branch = "IT" ,per=75},
                    new student() { firstname = "Pratik", lastname = "Hepat", smailid = "pratikhepat@gmail.com", branch = "IT",per=88 },
                    new student() { firstname = "Sandeep", lastname = "Potdhuke", smailid = "sandeeppotdhuke@gmail.com", branch = "CS",per=85 },
                    new student() { firstname = "Akshat", lastname = "Keoliya", smailid = "akshatkeoliya@gmail.com", branch = "IT",per=86 },
                    new student() { firstname = "Pradeep", lastname = "Mahur", smailid = "pradeepmahur@gmail.com", branch = "CS",per=73 },


                };
                Console.WriteLine("\n-----------Into Query-------------");
                Console.WriteLine("\n Joins equal per items in Slist and Slist2");
                var query18 = from i in Slist
                              join j in Slist2 on i.per equals j.per into res
                              select res;
                foreach (var j in query18)
                {
                    foreach (var i in j)
                    {
                        Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.branch + "," + i.per);
                    }
                }
                object[] obj = new object[] { 1, "String", 2, "Double", 0 };
                Console.WriteLine("---------------Oftype Query-------------");
                Console.WriteLine("All the integer type values in the obj");
                var query19 = obj.OfType<int>();
                foreach (var i in query19)
                {
                    Console.WriteLine(i);
                }


                Console.WriteLine("------------First Query--------------");
                var query20 = Slist.Where(i => i.per < 75).First();
                Console.WriteLine($"{query20.firstname},{query20.lastname},{query20.smailid},{query20.branch},{query20.per}");

                
                Console.WriteLine("------------FirstOrDefault Query--------------");
                var query21 = (from i in Slist where i.branch == "S" select i.per).FirstOrDefault();
                Console.WriteLine(query);

                Console.WriteLine("\n------------Last Query--------------");
                var query22 = Slist.Where(i => i.per < 88).Last();
                Console.WriteLine($"{query22.firstname},{query22.lastname},{query22.smailid},{query22.branch},{query22.per}");

                Console.WriteLine("------------LastOrDefault Query--------------");
                var query23 = (from i in Slist where i.branch == "CS" select i.per).LastOrDefault();
                Console.WriteLine(query23);


                int[] nos = new int[] { 10, 20, 10, 30, 20, 40, 50, 10, 60, 70, 80 };
                Console.WriteLine("\n------------Single--------------");
             
                var query24= (from i in nos where i == 60 select i).Single();
                Console.WriteLine(query24);
                Console.WriteLine("\n------------Single or default--------------");
                var query25 = (from i in nos where i == 600 select i).SingleOrDefault();
            
              

                Console.WriteLine(query25);

         
                Console.WriteLine($"\n-----------Deffrered Execution-----------------");
                var query26 = from i in Slist select i;
                Slist.Add(new student() { firstname = "Nikhil", lastname = "Prasad", smailid = "nikhil@gmail.com", branch = "EE", per = 86 });
                foreach (var i in query26)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.branch + "," + i.per);
                }




                Console.WriteLine($"\n-----------Immediate Execution-----------------");
                var query27 = (from i in Slist where i.per < 85 select i).Count();
                Slist.Add(new student() { firstname = "Nikhil", lastname = "Prasad", smailid = "nikhil@gmail.com", branch = "EE", per = 60 });
                Console.WriteLine($"Count of all values pre<85 : {query27}");

                Console.WriteLine("\n------------StartsWith Query-------------------");
                var query28 = Slist.Where(i => i.firstname.StartsWith('A'));
                foreach (var i in query28)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.branch + "," + i.per);
                }
                Console.WriteLine("\n------------EndsWith Query-------------------");
                var query29 = Slist.Where(i => i.firstname.EndsWith('p'));
                foreach (var i in query29)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.branch + "," + i.per);
                }
                Console.WriteLine("\n------------Contains Query-------------------");
                var query30 = Slist.Where(i => i.firstname.Contains('P'));
                foreach (var i in query30)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.branch + "," + i.per);
                }
                Console.WriteLine("\n-------------IEnumarable---------------");
                IEnumerable<student> query31 = from i in Slist select i;
                query31 = query31.Take(2);
                foreach (var i in query31)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.branch + "," + i.per);
                }
                Console.WriteLine("\n-------------IQuerable-----------------");
                IQueryable<student> query32 = Slist.AsQueryable();
                query32 = query32.Take(2);
                foreach (var i in query32)
                {
                    Console.WriteLine(i.firstname + "," + i.lastname + "," + i.smailid + "," + i.branch + "," + i.per);
                }


            }
        }
    }
}
    




   