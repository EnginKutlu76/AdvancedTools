using System.Collections.Generic;
using UnityEngine;

public class Quadtree
{
    private Rect boundary;
    private int capacity;

    private List<Vector2> points;

    private bool divided;

    private Quadtree northWest;
    private Quadtree northEast;
    private Quadtree southWest;
    private Quadtree southEast;

    public Quadtree(Rect boundary, int capacity)
    {
        this.boundary = boundary;
        this.capacity = capacity;

        points = new List<Vector2>();
        divided = false;
    }

    public bool Insert(Vector2 point)
    {
        // Nokta bu node'un içinde deðil
        if (!boundary.Contains(point))
            return false;

        // Yer varsa direkt ekle
        if (points.Count < capacity)
        {
            points.Add(point);
            return true;
        }

        // Ýlk kez dolduysa böl
        if (!divided)
            Subdivide();

        // Alt node'lara gönder
        if (northWest.Insert(point)) return true;
        if (northEast.Insert(point)) return true;
        if (southWest.Insert(point)) return true;
        if (southEast.Insert(point)) return true;

        return false;
    }

    private void Subdivide()
    {
        float x = boundary.x;
        float y = boundary.y;
        float w = boundary.width / 2;
        float h = boundary.height / 2;

        northWest = new Quadtree(new Rect(x, y + h, w, h), capacity);
        northEast = new Quadtree(new Rect(x + w, y + h, w, h), capacity);
        southWest = new Quadtree(new Rect(x, y, w, h), capacity);
        southEast = new Quadtree(new Rect(x + w, y, w, h), capacity);

        divided = true;
    }

    public void Query(Rect range, List<Vector2> found)
    {
        // Arama alaný bu node'a deðmiyor
        if (!boundary.Overlaps(range))
            return;

        // Node içindeki noktalarý kontrol et
        foreach (Vector2 point in points)
        {
            if (range.Contains(point))
                found.Add(point);
        }

        // Alt node yoksa bitir
        if (!divided)
            return;

        northWest.Query(range, found);
        northEast.Query(range, found);
        southWest.Query(range, found);
        southEast.Query(range, found);
    }

    /*
        ///Kullanýmý///
        Quadtree tree = new Quadtree(
        new Rect(0, 0, 100, 100),
        4);  Her node en fazla 4 obje tutabilir

        ///Nokta Ekleme///
        tree.Insert(new Vector2(10, 20));
        tree.Insert(new Vector2(15, 18));
        tree.Insert(new Vector2(70, 40));
        tree.Insert(new Vector2(80, 75));
        tree.Insert(new Vector2(90, 90));

        ///Yakýndaki objeleri bulmak///
        List<Vector2> result = new();

        Rect searchArea =
            new Rect(40, 40, 20, 20);

        tree.Query(searchArea, result);

        foreach (var point in result)
        {
            Debug.Log(point);
        }
*/
}