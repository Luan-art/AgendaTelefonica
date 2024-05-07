using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    internal class Contact
    {
        string name;
        string email;
        Address address;
        PhonesList phonesList;
        
        Contact? next;

        public Contact(string name, string email, Address address, PhonesList phonesList)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.phonesList = phonesList;
        }

        public string getName()
        {
            return name;
        }
        public Contact getNext()
        {
            return this.next;
        }
        public string getEmail()
        {
            return email;
        }
        public Address getAddress()
        {
            return address;
        }
        public PhonesList getPhonesList()
        {
            return phonesList;
        }
        public void setNext(Contact c)
        {
            this.next = c;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setAddress(Address address)
        {
            this.address = address;
        }

        public void setPhonesList(PhonesList phonesList)
        {
            this.phonesList = phonesList;
        }


        public override string ToString()
        {
            string contactInfo = "\nNome: " + this.name + "\nEmail: " + this.email + "\nEndereço: "
                + this.address.ToString()+ "\nNúmeros:\n";

            Phone aux = phonesList.getHead();
            while (aux != null)
            {
                contactInfo += aux.ToString() + "\n";
                aux = aux.getNext();
            }

            return contactInfo;
        }
    }
}
