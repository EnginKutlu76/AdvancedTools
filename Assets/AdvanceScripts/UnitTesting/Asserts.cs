using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Asserts : MonoBehaviour
{

    [Test]
    public void Damage()
    {
        int damage = 20 - 5;

        Assert.AreEqual(15, damage);
        // Assert.AreEqual(0.3f, value); yanlýþtýr  çünkü tam hassas deðildir
        //Assert.AreEqual(0.3f, value, 0.001f); doðrusu budur veya Assert.That(value, Is.EqualTo(0.3f).Within(0.001f));
    }

    [Test]
    public void Damage1()
    {
        int damage = 20 - 5;

        Assert.AreNotEqual(15, damage);
    }
/*
    //Boolean Assertions
    Assert.IsTrue(player.IsAlive);
    Assert.IsFalse(player.IsDead);

    /*Null Assertions
    Assert.IsNull(item);
    Assert.IsNotNull(player);

    /*Reference Assertions
    Assert.AreSame(player1, player2);
    Assert.AreNotSame(player1, player2);

    /*Type Assertions
    Assert.IsInstanceOf<Player>(obj);
    Assert.IsNotInstanceOf<Enemy>(obj);

    /*Collection Assertions
    CollectionAssert.AreEqual(expected, actual);
    int[] a = { 1, 2, 3 };

    int[] b = { 1, 2, 3 };

    CollectionAssert.AreEqual(a, b);

    CollectionAssert.Contains(items, sword);

    CollectionAssert.DoesNotContain(items, potion);

    CollectionAssert.IsSubsetOf(small, big);

    /*String Assertions
    Assert.AreEqual("Player", name);
    StringAssert.Contains("Fire", spellName);
    StringAssert.StartsWith("Player", fileName);
    StringAssert.EndsWith(".json", saveFile);
    StringAssert.IsMatch(pattern, text);

    /*Exception Assertions
    Assert.Throws<DivideByZeroException>(
    ()=> calculator.Divide(5,0));

    Assert.DoesNotThrow(
    ()=> Save());


    /*********Constraint Model******
    NuUnitin modern kullaným þeklidir
    Assert.AreEqual(5,result); Eski
    Assert.That(result, Is.EqualTo(5)); Yeni

    /*Assert.Multiple -> çoklu assertionlarda kullanýlýr
    Assert.Multiple(() =>
    {
        Assert.AreEqual(...);

        Assert.IsTrue(...);

        Assert.IsNotNull(...);
    });
        */
}
