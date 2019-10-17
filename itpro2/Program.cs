using System;

namespace itpro
{

    class Program
    {
        /// <summary>
        /// To print Esealy and Good 
        /// </summary>
        /// <param name="s">the internal String</param>
        /// <param name="IsWriteLine">Is Writeline?</param>
        /// <param name="adad">the internal number</param>
        public static void print(string s = "", bool IsWriteLine = true, int adad = -1)
        {
            if (IsWriteLine)
            {
                if (adad == -1)
                    Console.WriteLine(s);
                else
                    Console.WriteLine(adad);
            }
            else
            {
                if (adad == -1)
                    Console.Write(s);
                else
                    Console.Write(adad);
            }
        }
        private static string MainMenu()
        {
            print("to add contact Enter 1");
            print("to remove contact Enter 2");
            print("to Edit contact Enter 3");
            print("to show contatc Enter 4");
            print("to Exit program Enter 5:", false);
            string toutal = Console.ReadLine();
            Console.Clear();
            return toutal;
        }
        private static Contact NewContact()
        {
            Contact q = new Contact();
            print("Enter Name:", false);
            q.Name = Console.ReadLine();
            print("Enter Family:", false);
            q.Family = Console.ReadLine();
            print("Enter Phone:", false);
            q.Phone = Console.ReadLine();
            print("Enter Email:", false);
            q.Email = Console.ReadLine();
            return q;
        }

        static void Main(string[] args)
        {
            Book book = new Book();
            bool Exit = false;
            while (!Exit)
            {

                Console.Clear();
                print("Welcome To Your TellBook(NumberContact=" + book.NumberContact + ")");
                string mM = MainMenu();
                switch (mM)
                {
                    case "1":
                        Contact contact = new Contact();
                        contact = NewContact();
                        book.add(contact);
                        break;
                    case "2":
                        print("Enter Phone:", false);
                        string number = Console.ReadLine();
                        bool a = book.remove(number);
                        if (a)
                            print(number + "Is Successfull deleted");
                        else
                            print("this number is not found!");
                        Console.Read();
                        break;

                    case "3":
                        print("Enter Number to Edit:", false);
                        string s = Console.ReadLine();
                        if (book.SearchByNumber(s) == null)
                        {
                            print("The number:" + s + " is Not Exit");
                            Console.ReadKey();
                            break;
                        }
                        print("Now Enter New information about " + s);
                        Contact tempForEdit = NewContact();
                        book.Edit(tempForEdit, Console.ReadLine());
                        break;
                    case "4":

                        print("Enter Name");
                        string s1 = Console.ReadLine();
                        Contact resault = new Contact();
                        int i = 0;
                        do
                        {
                            if (i == 0)
                                resault = book.Search(s1, true);
                            else
                                resault = book.Search(s1, false);
                            book.ShowOneContact(resault);
                            i++;
                        } while (resault != null);
                        Console.ReadKey();
                        break;
                    case "5":
                        print("Have a Good Time");
                        Exit = true;
                        break;

                }
            }


            laptop a = new laptop();
            double xx = a.Price;

        }
    }
    abstract class computer
    {
        public int Ram { get; set; }
        public int Hard { get; set; }
        public double Price { get { return Ram + Hard; } }

    }
    class laptop : computer
    {
        public int power_price { get; set; }
        public double Price { get { return Ram * 2 + Hard * 3; } }

    }

}
