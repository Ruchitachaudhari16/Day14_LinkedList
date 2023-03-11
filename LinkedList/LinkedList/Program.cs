namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1 create a simple Linked list 56-30-70
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}