using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericListCollectionDemo
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();

            Employee emp1 = new Employee() { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = DateTime.Parse("16/11/1984"), DOJ = DateTime.Parse("8/6/2011"), City = "Mumbai" };
            Employee emp2 = new Employee() { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = DateTime.Parse("20/08/1984"), DOJ = DateTime.Parse("7/7/2012"), City = "Mumbai" };
            Employee emp3 = new Employee() { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = DateTime.Parse("14/11/1987"), DOJ = DateTime.Parse("12/4/2015"), City = "Pune" };
            Employee emp4 = new Employee() { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("3/6/1990"), DOJ = DateTime.Parse("2/2/2016"), City = "Pune" };
            Employee emp5 = new Employee() { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("8/3/1991"), DOJ = DateTime.Parse("2/2/2016"), City = "Mumbai" };
            Employee emp6 = new Employee() { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.Parse("7/11/1989"), DOJ = DateTime.Parse("8/8/2014"), City = "Chennai" };
            Employee emp7 = new Employee() { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = DateTime.Parse("2/12/1989"), DOJ = DateTime.Parse("1/6/2015"), City = "Mumbai" };
            Employee emp8 = new Employee() { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = DateTime.Parse("11/11/1993"), DOJ = DateTime.Parse("6/11/2014"), City = "Chennai" };
            Employee emp9 = new Employee() { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = DateTime.Parse("12/8/1992"), DOJ = DateTime.Parse("3/12/2014"), City = "Chennai" };
            Employee emp10 = new Employee() { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = DateTime.Parse("12/4/1991"), DOJ = DateTime.Parse("2/1/2016"), City = "Pune" };

            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            empList.Add(emp6);
            empList.Add(emp7);
            empList.Add(emp8);
            empList.Add(emp9);
            empList.Add(emp10);
            
    //Linq quries to fetch data
        // a) Display details of all the employee
            var all = from i in empList select i;

            foreach (Employee emp in all)
            {
                Console.WriteLine(emp.EmployeeID+" "+emp.FirstName+" "+emp.LastName+" "+emp.Title+" "+emp.DOB.Date+" "+emp.DOJ.Date+" "+emp.City);
            }

        // b) Display details of all the employee whose location is not Mumbai
            var NotMumbai = from i in empList where i.City!="Mumbai" select i;

            foreach (Employee emp in NotMumbai)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.Date + " " + emp.DOJ.Date + " " + emp.City);
            }

        // c) Display details of all the employee whose title is AsstManager
            var AstManager = from i in empList where i.Title=="AsstManager" select i;

            foreach (Employee emp in AstManager)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.Date + " " + emp.DOJ.Date + " " + emp.City);
            }

        // d) Display details of all the employee whose LastName start with S
            var nameWithS = from i in empList where i.LastName.ToLower().StartsWith("s") select i;

            foreach (Employee emp in nameWithS)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.Date + " " + emp.DOJ.Date + " " + emp.City);
            }
            

        // e) Display a list of all the employee who have joined before 1/1/2015
            var Joindate = from i in empList where i.DOJ<new DateTime(2015,1,1) select i;

            foreach (Employee emp in Joindate)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.Date + " " + emp.DOJ.Date + " " + emp.City);
            }

        // f) Display a list of all the employee whose date of birth is after 1/1/1990
            var doba = from i in empList where i.DOJ > new DateTime(1990, 1, 1) select i;

            foreach (Employee emp in doba)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.Date + " " + emp.DOJ.Date + " " + emp.City);
            }

        // g) Display a list of all the employee who designation is Consultant and Associate
            var conAss = from i in empList where i.Title=="Consultant" && i.Title=="Associate" select i;

            foreach (Employee emp in conAss)
            {
                Console.WriteLine(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName + " " + emp.Title + " " + emp.DOB.Date + " " + emp.DOJ.Date + " " + emp.City);
            }

        // h) Display total number of employees
            var totalEmp = empList.Count();
            Console.WriteLine(totalEmp);

        // i) Display total number of employees belonging to "Chennai"
            var CheEmp = from i in empList where i.City == "Chennai" select i;
            Console.WriteLine(CheEmp.Count());

        // j) Display highest employee id from the list
            var HighEmpId = empList.Max(x => x.EmployeeID);
            Console.WriteLine(HighEmpId);

        // k) Display total number of employee who have joined after 1/1/2015
            var Noe = from i in empList where i.DOJ > new DateTime(2015, 1, 1) select i;
            Console.WriteLine(Noe.Count());

        // l) Display total number of employee whose designation is not "Associate"
            var Assdes = from i in empList where i.Title!="Associate" select i;
            Console.WriteLine(Assdes.Count());

        // m) Display total number of employee based on city
            var CountByCity = empList.GroupBy(x => x.City).ToList();
            foreach(var emp in CountByCity)
            {
                Console.WriteLine(emp.Key+":"+emp.Count());
            }

        // n) Display total number of employee based on title
            var CountByCityTitle = empList.GroupBy(x=>x.Title).ToList();
            foreach (var emp in CountByCityTitle)
            {
                Console.WriteLine(emp.Key + ":" + emp.Count());
            }

        // o) Display total number of employee who is youngest in the list
            var YoungEmp = empList.Min(x => x.DOB);
            Console.WriteLine(YoungEmp);
            Console.ReadLine();
        }
    }
}