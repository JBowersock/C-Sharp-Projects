using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1.
            List<Employees> employee = new List<Employees>(); //Creating 'employee' from class 'Employees'.

            //Employee 1.
            Employees employee1 = new Employees(); //Creating employee1.
            employee1.firstName = "Eddard"; //Assigning firstName.
            employee1.lastName = "Stark"; //Assigning lastName.
            employee1.id = 1; //Assigning ID.
            //employee.Add(employee1); //Adding employee to List.

            //Employee 2.
            Employees employee2 = new Employees(); //Creating employee1.
            employee2.firstName = "Jon"; //Assigning firstName.
            employee2.lastName = "Snow"; //Assigning lastName.
            employee2.id = 2; //Assigning ID.
            employee.Add(employee2); //Adding employee to List.

            //Employee 3.
            Employees employee3 = new Employees(); //Creating employee1.
            employee3.firstName = "Robb"; //Assigning firstName.
            employee3.lastName = "Stark"; //Assigning lastName.
            employee3.id = 3; //Assigning ID.
            employee.Add(employee3); //Adding employee to List.

            //Employee 4.
            Employees employee4 = new Employees(); //Creating employee1.
            employee4.firstName = "Catelyn"; //Assigning firstName.
            employee4.lastName = "Stark"; //Assigning lastName.
            employee4.id = 4; //Assigning ID.
            employee.Add(employee4); //Adding employee to List.

            //Employee 5.
            Employees employee5 = new Employees(); //Creating employee1.
            employee5.firstName = "Arya"; //Assigning firstName.
            employee5.lastName = "Stark"; //Assigning lastName.
            employee5.id = 5; //Assigning ID.
            employee.Add(employee5); //Adding employee to List.

            //Employee 6.
            Employees employee6 = new Employees(); //Creating employee1.
            employee6.firstName = "Joe"; //Assigning firstName.
            employee6.lastName = "Stark"; //Assigning lastName.
            employee6.id = 6; //Assigning ID.
            employee.Add(employee6); //Adding employee to List.

            //Employee 7.
            Employees employee7 = new Employees(); //Creating employee1.
            employee7.firstName = "Bran"; //Assigning firstName.
            employee7.lastName = "Stark"; //Assigning lastName.
            employee7.id = 7; //Assigning ID.
            employee.Add(employee7); //Adding employee to List.

            //Employee 8.
            Employees employee8 = new Employees(); //Creating employee1.
            employee8.firstName = "Daenerys"; //Assigning firstName.
            employee8.lastName = "Targaryen"; //Assigning lastName.
            employee8.id = 8; //Assigning ID.
            employee.Add(employee8); //Adding employee to List.

            //Employee 9.
            Employees employee9 = new Employees(); //Creating employee1.
            employee9.firstName = "Joe"; //Assigning firstName.
            employee9.lastName = "Lannister"; //Assigning lastName.
            employee9.id = 9; //Assigning ID.
            employee.Add(employee9); //Adding employee to List.

            //Employee 10.
            Employees employee10 = new Employees(); //Creating employee1.
            employee10.firstName = "Jamie"; //Assigning firstName.
            employee10.lastName = "Lannister"; //Assigning lastName.
            employee10.id = 10; //Assigning ID.
            employee.Add(employee10); //Adding employee to List.

            //Step 2.
            List<Employees> fNameSearch = new List<Employees>(); //Creating 'fNameSearch' from class 'Employees'.
            foreach (Employees employees in employee) //Foreach Loop.
            {
                if (employees.firstName == "Joe") //If Statement.
                {
                    fNameSearch.Add(employees); //Adding to List.
                    Console.WriteLine(employees.firstName + " " + employees.lastName); //Prints values.
                }
            }

            Console.WriteLine(); //Line Break.

            //Step 3.
            List<Employees> fNameLambda = employee.Where(x => x.firstName == "Joe").ToList(); //Creating 'fNameLambda' from class 'Employees'.
            foreach (Employees employees in fNameLambda) //Foreach Loop.
            {
                Console.WriteLine(employees.firstName + " " + employees.lastName); //Prints values.
            }

            Console.WriteLine(); //Line Break.

            //Step 4.
            List<Employees> idMoreThanFive = employee.Where(x => x.id > 5).ToList(); //Creating 'idMoreThanFive' from class 'Employees'.
            foreach (Employees employees in idMoreThanFive) //Foreach Loop.
            {
                Console.WriteLine($"{ employees.firstName } { employees.lastName }'s ID number is { employees.id }."); //Prints string and values.
            }

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
