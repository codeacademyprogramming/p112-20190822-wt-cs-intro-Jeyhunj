using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountAppProj

{
    class Program
    {
        static void Main(string[] args)
        {
            // Take Informations
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter ID");
            int idNumber = Convert.ToInt32(Console.ReadLine());

            AccountInfo account = new AccountInfo(name, surname, idNumber);

            // Cases and Methods with Switch

            int selected = -9;

            while (selected != 0)
            {
                Console.WriteLine();
                selected = showMenu();
                switch (selected)
                {
                    case 1:
                        Console.WriteLine("Balance of Account:" + " " + account.getBalance());
                        break;
                    case 2:
                        Console.WriteLine("Enter Amount");
                        int addAmount = Convert.ToInt32(Console.ReadLine());
                        account.addToBalance(addAmount);
                        break;
                    case 3:
                        Console.WriteLine("Enter Amount");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        account.withdrawFromBalance(withdrawAmount);
                        break;
                    case 4:
                        Console.WriteLine("Name");
                        string changeName = Console.ReadLine();
                        if (String.IsNullOrEmpty(changeName))
                        {
                            changeName = account.getFirstName();
                        }

                        Console.WriteLine("Surname");
                        string changeSurname = Console.ReadLine();
                        if (String.IsNullOrEmpty(changeSurname))
                        {
                            changeName = account.getLastName();
                        }

                        Console.WriteLine("ID number");
                        string changeIDString = Console.ReadLine();
                        int changeID;
                        if (String.IsNullOrEmpty(changeIDString))
                        {
                            changeID = account.getIdNumber();
                        }
                        else
                        {
                            changeID = Convert.ToInt32(changeIDString);
                        }

                        account.updateCredentials(changeName, changeSurname, changeID);
                        break;
                    case 0:
                        break;
                }
            }

            Console.ReadLine();
        }

        static int showMenu()
        {
            Console.WriteLine("1. See the Balance");
            Console.WriteLine("2. Increase Balance");
            Console.WriteLine("3. Delete from Balance");
            Console.WriteLine("4. Change Account Informations");
            Console.WriteLine("0. Exit");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
