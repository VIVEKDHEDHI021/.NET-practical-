using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    class Expense
    {
        public int expId;
        public string category;
        public double amt;
        public string paymentmode;
        public DateTime expDate;

        public void accDetails()
        {
            Console.Write("Enter Expense Id :");
            expId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Expense category :");
            category = Console.ReadLine();

            Console.Write("Enter Expense Amount:");
            amt = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Expense PaymentMode :");
            paymentmode = Console.ReadLine();

            expDate = DateTime.Now;

            if (amt <= 0)
            {
                throw new Exception("Expense Must be more than Zero");
            }

        }

        public void display()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Expense Id =" + expId);
            Console.WriteLine("Expense category =" + category);
            Console.WriteLine("Expense Amout =" + amt);
            Console.WriteLine("Expense Mode =" + paymentmode);
            Console.WriteLine("Date =" + expDate);
            Console.WriteLine("***************************");




        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch = 0;
            List<Expense> expenses = new List<Expense>();

            do
            {
                Console.WriteLine("**********************");
                Console.WriteLine("EXPENSE TRACKER MODULE");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View All Expenses");
                Console.WriteLine("3. View Total Expense");
                Console.WriteLine("4. Exit");
                Console.WriteLine("**********************");

                try
                {
                    Console.Write("Enter Your Choice : ");
                    ch = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            Expense e = new Expense();
                            e.accDetails();
                            expenses.Add(e);
                            Console.WriteLine("Expense Added Successfully.");
                            break;

                        case 2:
                            if (expenses.Count == 0)
                            {
                                Console.WriteLine("No Expense Found.");
                            }
                            else
                            {
                                foreach (Expense exp in expenses)
                                {
                                    exp.display();
                                }
                            }
                            break;

                        case 3:
                            double total = 0;

                            foreach (Expense exp in expenses)
                            {
                                total += exp.amt;
                            }

                            Console.WriteLine("Total Expense = " + total);
                            break;

                        case 4:
                            Console.WriteLine("Thank You!");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message);
                }

            } while (ch != 4);
        }

    }
}
