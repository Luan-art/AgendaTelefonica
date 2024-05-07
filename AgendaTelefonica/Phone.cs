


namespace AgendaTelefonica
{
    internal class Phone
    {
        string number;
        Phone? next;

        public Phone(string number)
        {
            this.number = number;
        }

        public string? getNumber()
        {
            return number;
        }

        public void setNext(Phone aux)
        {
            this.next = aux;
         }

        public Phone getNext()
        {
            return next;
        }

        public override string? ToString()
        {
            return "Número: " + this.number;
        }
    }
}