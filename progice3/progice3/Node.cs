using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace progice3
{
    public class Node
    {
        public GameScript Data;
        public Node next;
        public Node previous;
        public Node(GameScript data)
        {
            Data = data;
            next = null;
            previous = null;
        }
    }

    public class ScriptDLinkedList
    {
        private Node head;

        public ScriptDLinkedList()
        {
            head = null;
        }

        public Node GetHead()
        {
            return head;
        }

        public void Add(GameScript script)
        {
            Node newNode = new Node(script);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
                newNode.previous = current;
            }
        }
        public void SortGameScript()
        {
            if (head == null)
                return;

            bool swapped;
            Node current;

            do
            {
                swapped = false;
                current = head;

                while (current.next != null)
                {
                    if (current.Data.storyNumber > current.next.Data.storyNumber)
                    {
                        
                        GameScript temp = current.Data;
                        current.Data = current.next.Data;
                        current.next.Data = temp;

                        swapped = true;
                    }
                    current = current.next;
                }
            } while (swapped);
        }

        
        public List<string> GetSortedGameScript()
        {
            List<string> storylines = new List<string>();
            Node current = head;
            while (current != null)
            {
                storylines.Add($"{current.Data.storyNumber}: {current.Data.storyLine}");
                current = current.next;
            }
            return storylines;
        }
    }
}

