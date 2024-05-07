namespace AgendaTelefonica
{
    internal class PhonesList
    {
        Phone? head;
        Phone? tail;

        public void Add(Phone phone)
        {
            if (isEmpty())
            {
                this.head = phone;
                this.tail = phone;
            }
            else
            {
                int compare = string.Compare(phone.getNumber(), head.getNumber(), comparisonType: StringComparison.OrdinalIgnoreCase);
                if (compare <= 0)
                {
                    Phone aux = head;
                    head = phone;
                    head.setNext(aux);
                }
                else
                {
                    Phone aux = head;
                    Phone prev = head;

                    do
                    {
                        compare = string.Compare(phone.getNumber(), aux.getNumber());
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }

                    } while (aux != null && compare > 0);

                    prev.setNext(phone);
                    phone.setNext(aux);
                    if (aux == null)
                        tail = phone;
                }
            }
        }

        bool isEmpty()
        {
            if (this.head == null && this.tail == null)
                return true;
            else
                return false;
        }

        public void RemoveByName(string name)
        {
            if (!isEmpty())
            {
                if (name == this.head.getNumber())
                {
                    if (head == tail)
                        tail = head = null;
                    else
                    {
                        head = head.getNext();
                    }
                }
                else
                {
                    Phone aux = head;
                    Phone prev = head;
                    bool compare;
                    do
                    {
                        compare = name.Equals(aux.getNumber());
                        if (!compare)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                        else
                        {
                            prev.setNext(aux.getNext());
                            if (prev.getNext() == null)
                                tail = prev;
                        }

                    } while (compare == false && aux != null);

                    if (aux == null)
                    {
                        Console.WriteLine("Não existe o contato na lista.");
                    }
                }
            }
        }

        public void ShowAll()
        {
            Phone aux = head;
            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.getNext();
            } while (aux != null);
        }

        public Phone getHead()
        {
            return this.head;
        }
    }
}