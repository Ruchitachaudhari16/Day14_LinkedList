using System.Collections.Generic;
using System.Xml.Linq;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC5 Ability to delete the lastelement in the LinkedList of sequence 56->30->70


            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InserAtParticularPosition(2, 51);
            //It will remove the first element
            list.RemoveFirstNode();
            //It will removethe last element
            list.RemoveLastNode();
            list.Display();
        }
    }
}