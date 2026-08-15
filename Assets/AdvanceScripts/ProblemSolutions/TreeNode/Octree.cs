using System.Collections.Generic;
using UnityEngine;

public class Octree
{
    private Bounds boundary;
    private int capacity;

    private List<Vector3> points;

    private bool divided;

    private Octree[] children;

    public Octree(Bounds boundary, int capacity)
    {
        this.boundary = boundary;
        this.capacity = capacity;

        points = new List<Vector3>();

        children = new Octree[8];
    }

    public bool Insert(Vector3 point)
    {
        if (!boundary.Contains(point))
            return false;

        if (points.Count < capacity)
        {
            points.Add(point);
            return true;
        }

        if (!divided)
            Subdivide();

        foreach (Octree child in children)
        {
            if (child.Insert(point))
                return true;
        }

        return false;
    }

    private void Subdivide()
    {
        divided = true;

        Vector3 size = boundary.size / 2;
        Vector3 center = boundary.center;

        int index = 0;

        for (int x = -1; x <= 1; x += 2)
        {
            for (int y = -1; y <= 1; y += 2)
            {
                for (int z = -1; z <= 1; z += 2)
                {
                    Vector3 childCenter =
                        center + new Vector3(
                            x * size.x / 2,
                            y * size.y / 2,
                            z * size.z / 2);

                    children[index++] =
                        new Octree(
                            new Bounds(childCenter, size),
                            capacity);
                }
            }
        }
    }

    public void Query(Bounds range, List<Vector3> found)
    {
        if (!boundary.Intersects(range))
            return;

        foreach (Vector3 point in points)
        {
            if (range.Contains(point))
                found.Add(point);
        }

        if (!divided)
            return;

        foreach (Octree child in children)
        {
            child.Query(range, found);
        }
    }
}