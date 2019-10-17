using System;
using System.Collections.Generic;
using System.Text;

namespace itpro
{
    class Book
    {
        private Contact[] contacts = new Contact[20];
        public bool add(Contact contact)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] == null)
                {
                    contacts[i] = contact;
                    return true;
                }
            }
            return false;
        }
        public bool remove(Contact contact)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i].Equals(contact))
                {
                    contacts[i] = null;
                    return true;
                }
            }
            return false;
        }
        public bool remove(string number)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] != null)
                    if (contacts[i].Phone == number)
                    {
                        contacts[i] = null;
                        return true;
                    }
            }
            return false;
        }
        public int NumberContact
        {
            get
            {
                int a = 0;
                for (int i = 0; i < contacts.Length; ++i)
                    if (contacts[i] != null)
                        a++;
                return a;

            }
        }
        int a = 0;
        public Contact Search(string name, bool IsOneTime = false)
        {
            if (IsOneTime)
                a = 0;
            int es = 0;
            for (int i = 0; i < contacts.Length; ++i)
            {
                if (contacts[i] != null && contacts[i].Name == name)
                {
                    if (es == a)
                    {
                        a++;
                        return contacts[i];
                    }
                    es++;
                }
            }
            return null;
        }
        public bool ShowOneContact(Contact cn)
        {
            if (cn != null)
            {

                Console.WriteLine("\n******************Name:" + cn.Name + "*******************");
                Console.WriteLine("Family:" + cn.Family);
                Console.WriteLine("Email:" + cn.Email);
                Console.WriteLine("Phone:" + cn.Phone);
                Console.WriteLine();
                return true;
            }
            Console.WriteLine(" the Search Is Finshed");
            return false;
        }
        public bool Edit(Contact temp, string number)
        {
            if (temp != null)
            {
                for (int i = 0; i < contacts.Length; ++i)
                {
                    if (contacts[i] != null && contacts[i].Phone == number)
                    {
                        contacts[i].Name = temp.Name;
                        contacts[i].Family = temp.Family;
                        contacts[i].Email = temp.Email;
                        contacts[i].Phone = temp.Phone;
                        Console.WriteLine("The Edit is Successfully done");
                        return true;
                    }
                }
            }
            Console.WriteLine("Sorry Is a problem With your contact is not found!");
            return false;
        }
        public Contact SearchByNumber(string num)
        {
            for (int i = 0; i < contacts.Length; i++)
                if (contacts[i] != null)
                    if (contacts[i].Phone == num)
                        return contacts[i];
            return null;
        }
    }
}
