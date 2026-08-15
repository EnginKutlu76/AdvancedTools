using System;

/*********HashCode*********/
public class Player
{
    public int Id { get; }
    public string Name { get; }

    public Player(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override bool Equals(object obj)
    {
        if (obj is not Player other)
            return false;

        return Id == other.Id && Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
    }

    ///Kullanýmý///
    /*
    Dictionary<Player, int> scores = new();
    Player p1 = new Player(1, "Engin");
    scores[p1] = 1500;
    */
}