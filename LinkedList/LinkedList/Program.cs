using System.Collections.Generic;
using System.Xml.Linq;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC7 Ability to searchLinkedList to find Node with value 30


            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InserAtParticularPosition(2, 51);
            /*It will remove the first element
            list.RemoveFirstNode();
            It will removethe last element
            list.RemoveLastNode();*/

            //It will search node with value 30
            list.Search(30);
            list.Display();

        }
    }
}