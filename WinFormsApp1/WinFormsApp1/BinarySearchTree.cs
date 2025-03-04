using System;
using System.Collections.Generic;

namespace WinFormsApp1
{
    internal class BinarySearchTree
    {
        private class Node
        {
            public int TotalDaysRemaining; // Sorting based on this
            public string Data; // Stores "Name - Project | Remaining: X years Y months Z days"
            public Node Left, Right;

            public Node(int totalDays, string data)
            {
                TotalDaysRemaining = totalDays;
                Data = data;
                Left = Right = null;
                //
            }
        }

        private Node root;

        // Inserting algorithm 1
        // Insert function for projects (sorted by remaining days in descending order) 
        public void Insert(int totalDays, string details)
        {
            root = InsertRec(root, totalDays, details);
        }

        private Node InsertRec(Node root, int totalDays, string details)
        {
            if (root == null) return new Node(totalDays, details);

            if (totalDays > root.TotalDaysRemaining) // Higher remaining time goes left
                root.Left = InsertRec(root.Left, totalDays, details);
            else
                root.Right = InsertRec(root.Right, totalDays, details);

            return root;
        }

        // Inserting algorithm 2
        // Overloaded Insert function for usernames (sorted alphabetically)
        public void Insert(string username)
        {
            root = InsertRecAlpha(root, username);
        }

        private Node InsertRecAlpha(Node root, string username)
        {
            if (root == null) return new Node(0, username);

            if (string.Compare(username, root.Data) < 0) // Alphabetical order
                root.Left = InsertRecAlpha(root.Left, username);
            else
                root.Right = InsertRecAlpha(root.Right, username);

            return root;
        }

        //Algorithm 3
        // Inorder traversal for displaying sorted data
        public List<string> InOrderTraversal()
        {
            List<string> result = new List<string>();
            InOrderRec(root, result);
            return result;
        }

        //Algorithm 4
        private void InOrderRec(Node root, List<string> result)
        {
            if (root != null)
            {
                InOrderRec(root.Left, result);
                result.Add(root.Data); // Add data to list
                InOrderRec(root.Right, result);
            }
        }
    }
}
