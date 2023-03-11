using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC4 Ability to create Linked List by adding 30 and 56 to 70
            LinkedList list = new LinkedList();
            list.Add(56);
            //Here list.add (30) but 30 added to 70 position

            list.Add(70);
            //30 is added to 70
            list.InserAtParticularPosition(2, 30);
            list.Display();
        }
    }
}