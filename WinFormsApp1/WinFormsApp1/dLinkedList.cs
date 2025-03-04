//Group 55 


using System;

namespace WinFormsApp1
{
    public class Node
    {
        public int EXH { get; set; } // Extra Curricular Hours
        public int STH { get; set; } // Sleep Time Hours
        public string[] TSA = new string[9]; // Time Schedule Array 
        // The day is categorized into 9 , 1 hour sections
        //This can be changed as the times which we have selected shuffles and can be used in more applications
        public Node? next { get; set; }
        public Node? prev { get; set; }

        public Node()
        {
            EXH = 0;
            STH = 0;
            next = null;
            prev = null;
            for (int i = 0; i < 9; i++)
            {
                TSA[i] = "UNKNOWN";
            }
        }

        public Node(int exh, int sth, string[] tsa)
        {
            EXH = exh;
            STH = sth;
            TSA = tsa;
            next = null;
            prev = null;
        }
    }

    //This is the dLinkedList class which we have created
    public class dLinkedList
    {
        private Node? head;
        private Node? tail;
        private int size;

       
        public int EXH { get; set; } = 0;
        public int STH { get; set; } = 0;

        public dLinkedList()
        {
            size = 0;
            head = null;
            tail = null;
            EXH = 0;
            STH = 0;
        }

        public Node? GetHead()
        {
            return head; // A function to retun the head becuase in our application this is crucial.
        }

        public void insertLast(int exh, int sth, string[] tsa)
        {
            Node temp = new Node(exh, sth, tsa);

            if (tail == null)
            {
                head = temp;
                tail = temp;
            }
            else
            {
                temp.prev = tail;
                tail.next = temp;
                tail = temp;
            }

            size++;
        }
        //for editing daily data can use insert at and delete at, for further improvement of the program.

        public int[] freeTimeCalac(Node? current)
        {
            int[] freeTime = new int[9]; // 9 slots for a day

            if (current != null)
            {
                for (int i = 0; i < current.TSA.Length; i++)
                {
                    if (current.TSA[i] == "FREE")
                    {
                        freeTime[i] = 0;
                    }
                    else if (current.TSA[i] == "BUSY")
                    {
                        freeTime[i] = 1;
                    }
                    else
                    {
                        freeTime[i] = -1;
                    }
                }
            }

            return freeTime;
        }

        public int DailyFreeTimeCalc(int[] freeTimeArray) 
            //Worst case Time Complexity of O(n) in this function
            //Because there is only one for loop
        {
            // Count the number of busy slots
            int busySlots = 0;
            for (int i = 0; i < freeTimeArray.Length; i++)
            {
                if (freeTimeArray[i] == 1) // Busy slots are marked as 1
                {
                    busySlots++;
                }
            }

            // Calculate total free time by subtracting EXH, STH, and busy slots from 24
            int freeTime = 24 - (EXH + STH + busySlots);

            // Return the calculated free time
            return freeTime;
        }

    }
}
