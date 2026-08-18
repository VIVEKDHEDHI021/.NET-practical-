using System;

interface IPayroll
{
    void GetData();
    void CalculateSalary();
    void Display();
}

class Employee
{
    public int Id, Age;
    public string Name, email, Department, Address, Post;

    protected int Salary, HRA, TA, Bonus, Deduction, PF, Tax, Gross, Net;
    protected int Leave, LeaveDeduction;
}

class FullTimeEmp : Employee, IPayroll
{
    public void GetData()
    {
        Console.Write("Enter Employee ID : ");
        Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name : ");
        Name = Console.ReadLine();

        Console.Write("Enter Age : ");
        Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Email : ");
        email = Console.ReadLine();

        Console.Write("Enter Department : ");
        Department = Console.ReadLine();

        Console.Write("Enter Address : ");
        Address = Console.ReadLine();

        Console.Write("Enter Post : ");
        Post = Console.ReadLine();

        Console.Write("Enter Basic Salary : ");
        Salary = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Total Leave Days : ");
        Leave = Convert.ToInt32(Console.ReadLine());
    }

    public void CalculateSalary()
    {
        HRA = Salary * 20 / 100;
        TA = Salary * 10 / 100;
        Bonus = Salary * 15 / 100;

        Gross = Salary + HRA + TA + Bonus;

        PF = Salary * 12 / 100;
        Tax = Salary * 5 / 100;

        LeaveDeduction = 0;

        if (Leave > 2)
        {
            int ExtraLeave = Leave - 2;
            LeaveDeduction = ExtraLeave * (Salary / 30);
        }

        Deduction = PF + Tax + LeaveDeduction;
        Net = Gross - Deduction;
    }

    public void Display()
    {
        Console.WriteLine("\n========== FULL TIME EMPLOYEE ==========");
        Console.WriteLine("ID : " + Id);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Age : " + Age);
        Console.WriteLine("Email : " + email);
        Console.WriteLine("Department : " + Department);
        Console.WriteLine("Address : " + Address);
        Console.WriteLine("Post : " + Post);

        Console.WriteLine("\n------ Salary Details ------");
        Console.WriteLine("Basic Salary : " + Salary);
        Console.WriteLine("HRA (20%) : " + HRA);
        Console.WriteLine("TA (10%) : " + TA);
        Console.WriteLine("Bonus (15%) : " + Bonus);
        Console.WriteLine("Gross Salary : " + Gross);

        Console.WriteLine("\n------ Deduction Details ------");
        Console.WriteLine("PF (12%) : " + PF);
        Console.WriteLine("Tax (5%) : " + Tax);
        Console.WriteLine("Allowed Leaves : 2");
        Console.WriteLine("Leaves Taken : " + Leave);

        if (Leave > 2)
        {
            Console.WriteLine("Extra Leaves : " + (Leave - 2));
            Console.WriteLine("Leave Deduction : " + LeaveDeduction);
        }
        else
        {
            Console.WriteLine("Extra Leaves : 0");
            Console.WriteLine("Leave Deduction : 0");
        }

        Console.WriteLine("Total Deduction : " + Deduction);
        Console.WriteLine("Net Salary : " + Net);
    }
}

class PartTimeEmp : Employee, IPayroll
{
    int Hours, Rate;

    public void GetData()
    {
        Console.Write("Enter Employee ID : ");
        Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name : ");
        Name = Console.ReadLine();

        Console.Write("Enter Age : ");
        Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Email : ");
        email = Console.ReadLine();

        Console.Write("Enter Department : ");
        Department = Console.ReadLine();

        Console.Write("Enter Address : ");
        Address = Console.ReadLine();

        Console.Write("Enter Post : ");
        Post = Console.ReadLine();

        Console.Write("Enter Working Hours : ");
        Hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Rate Per Hour : ");
        Rate = Convert.ToInt32(Console.ReadLine());
    }

    public void CalculateSalary()
    {
        Salary = Hours * Rate;
        Tax = Salary * 2 / 100;
        Net = Salary - Tax;
    }

    public void Display()
    {
        Console.WriteLine("\n========== PART TIME EMPLOYEE ==========");
        Console.WriteLine("ID : " + Id);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Age : " + Age);
        Console.WriteLine("Email : " + email);
        Console.WriteLine("Department : " + Department);
        Console.WriteLine("Address : " + Address);
        Console.WriteLine("Post : " + Post);

        Console.WriteLine("\n------ Salary Details ------");
        Console.WriteLine("Working Hours : " + Hours);
        Console.WriteLine("Rate Per Hour : " + Rate);
        Console.WriteLine("Salary : " + Salary);
        Console.WriteLine("Tax (2%) : " + Tax);
        Console.WriteLine("Net Salary : " + Net);
    }
}

class Program
{
    static void Main(string[] args)
    {
        char ans = 'Y';

        do
        {
            Console.WriteLine("\n========== EMPLOYEE PAYROLL SYSTEM ==========");
            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.Write("Enter Your Choice : ");

            int ch = Convert.ToInt32(Console.ReadLine());

            IPayroll emp = null;

            switch (ch)
            {
                case 1:
                    emp = new FullTimeEmp();
                    break;

                case 2:
                    emp = new PartTimeEmp();
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    continue;
            }

            emp.GetData();
            emp.CalculateSalary();
            emp.Display();

            Console.Write("\nDo you want to enter another employee? (Y/N) : ");
            ans = Convert.ToChar(Console.ReadLine());

        } while (ans == 'Y' || ans == 'y');

        Console.WriteLine("\nThank You!");
        Console.ReadKey();
    }
}