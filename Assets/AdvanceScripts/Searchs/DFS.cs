using System.Collections.Generic;
using Unity.GraphToolkit.Editor;
using UnityEngine;

public class DFS
{
    public void Search(Node node, HashSet<Node> visited)
    {
        if (visited.Contains(node))
            return;

        visited.Add(node);

        //Debug.Log(node.Name);

        //foreach (Node neighbor in node.Neighbors)
        //{
        //    Search(neighbor, visited);
        //}
    }
}
