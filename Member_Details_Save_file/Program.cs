using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Member_Details_Save_file
{
    class Program
    {
        //AUTO GENERATE MEMBER NUMBER
        int memberNo;
        static int nextNo;
        static Program()
        {
            nextNo = 91200003;
        }
        Program()
        {
            memberNo = ++nextNo;
        }


        static void Main(string[] args)
        {

            //save Membership_details file on C drive 
            string file = @"C:\Membership_Details.txt";
            using (StreamWriter sw = new StreamWriter(file))
            {

                //Delare variable 
                string Member_Name, Member_Surname;
                string Member_Forename = "";
                int myBirthYear;
                char[] Relationship_Type = { 'D', 'H', 'W', 'A' };

                //user input text
                Console.WriteLine("\nPLEASE ENTER MEMBER DETAILS BELOW  ");
                Console.WriteLine("\n*********************************************************");

                Console.WriteLine("ENTER MEMBER NAME     :");
                Member_Name = Console.ReadLine();

                Console.WriteLine("\nENTER MEMBER SURNAME :");
                Member_Surname = Console.ReadLine();

                Console.WriteLine("\nENTER MEMBER FORENAME :");
                Member_Forename = Console.ReadLine();
                Console.Write("\nWHAT YEAR YOU WERE BORN ? ");
                myBirthYear = Convert.ToInt32(Console.ReadLine());

                int myAge = DateTime.Now.Year - myBirthYear;
                Console.WriteLine("\nEnter  ON DATE        : ");
                DateTime On_Date = DateTime.Parse(Console.ReadLine());

                //Output the User input 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n----------------------------------------------------------");
                Console.WriteLine("\nMembership Full Details : ");
                sw.WriteLine("\nMembership Full Details  ");
                sw.WriteLine("\n***************************************************************");

                Console.WriteLine("\n----------------------------------------------------------");
                Program s = new Program();
                Console.WriteLine("Membership Number   : {0}", s.memberNo);
                sw.WriteLine("Membership Number        : {0}", s.memberNo);
                sw.WriteLine("\nMember Name            : {0}", Member_Name);
                Console.WriteLine("\nMember Name       : {0}", Member_Name);
                sw.WriteLine("\nMember Surname         : {0}", Member_Surname);
                Console.WriteLine("\nMember Surname    : {0}", Member_Surname);
                sw.WriteLine("\nMember ForeName        : {0}", Member_Forename);
                Console.WriteLine("\nMember ForeName   : {0}", Member_Forename);

                sw.WriteLine("\nYour Age               :" + myAge + " Years old.");
                Console.WriteLine("\nYour Age          :" + myAge + " Years old.");

                sw.WriteLine("\nOn_Date                :{0}", On_Date.ToString("MM'/'d/yyyy"));
                Console.WriteLine("\nOn_Date           :{0}", On_Date.ToString("MM'/'d/yyyy"));


                DateTime off_date = new DateTime(2049, 12, 31, 18, 42, 0);

                sw.WriteLine("\nOff Date               :{0}", off_date.ToString("MM'/'d/yyyy"));
                Console.WriteLine("\nOff Date          :{0}", off_date.ToString("MM'/'dd/yyyy"));
                var dt = DateTime.Now;
                sw.WriteLine("\nTimestamp              : {0}", dt.ToString("MM/dd/yyyy"));
                Console.WriteLine("\nTimestamp         : {0}", dt.ToString("MM/dd/yyyy"));
                sw.WriteLine("\n***************************************************************");



                Console.ReadLine();
            }
            Console.WriteLine("Data Saved Successfully!");
            Console.ReadKey();

        }
    }
}
