using System.Collections.Generic;
using System.Xml.Linq;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC5 Ability to delete the firstelement in the LinkedList of sequence 56->30->70


            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Insertion of element at a position 
            list.InserAtParticularPosition(2, 51);
            //It will remove the first Node
            list.RemoveFirstNode();
            list.Display();
        }
    }
}