using System.Collections.Generic;
using Unity.GraphToolkit.Editor;
using UnityEngine;

public class BFS /*Breadth First Search*/
{
    public void Search(Node start)
    {
        Queue<Node> queue = new Queue<Node>();
        HashSet<Node> visited = new HashSet<Node>();

        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

           // Debug.Log(current.Name);

            //foreach (Node neighbor in current.Neighbors)
            //{
            //    if (!visited.Contains(neighbor))
            //    {
            //        visited.Add(neighbor);
            //        queue.Enqueue(neighbor);
            //    }
            //}
        }
    }
}