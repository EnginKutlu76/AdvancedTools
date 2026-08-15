using NUnit.Framework;
using Unity.VectorGraphics;
using UnityEngine;

public class UnitTestingExample : MonoBehaviour
{
    /*
     * Ýlk baþta sadece bir kez çalýþýr
    [OneTimeSetUp]
    public void Init()
    {
    }*/

    /*
     * Her testten önce çalýþýr
    [SetUp]
    public void Setup()
    {
        inventory = new Inventory();
    }*/


    /*****Kodumuz*****/
    public class MathUtility
    {
        public int Square(int x)
        {
            return x * x;
        }
    }

    /*****Test*****/
    [Test]
    public void Square_ShouldReturn25_WhenInputIs5()
    {
        // Arrange
        var math = new MathUtility();

        // Act
        int result = math.Square(5);

        // Assert
        Assert.AreEqual(25, result);

        /*Kullaným Alanlarý
        Damage hesaplama
        Inventory sistemi
        Pathfinding algoritmasý
        Utility sýnýflarý
        Match - 3 algoritmalarý
        Matematik iþlemleri*/
    }



    /*****Birden fazla senaryo*****/
    [TestCase(2, 4)]
    [TestCase(3, 9)]
    [TestCase(4, 16)]
    [TestCase(5, 25)]
    public void Square_Test(int input, int expected)
    {
        var math = new MathUtility();

        Assert.AreEqual(expected, math.Square(input));
    } /*tek tek yazmak yerine bu yöntemi dene*/


    /*****Dependency Injection ile text*****/

    /*
        --KÖTÜ TASARIM--
        public class PlayerManager
        {
            Database db = new Database();
        }

        --ÝYÝ TASARIM--
        public class PlayerManager
        {
            private readonly IDatabase database;

            public PlayerManager(IDatabase database)
            {
                this.database = database;
            }
        }*/


    /*
     * IEnumerator döndürmek zorundadýr!
    [UnityTest]
    public IEnumerator WaitOneFrame()
    {
        yield return null;

        Assert.IsTrue(true);

    Nelerde kullanýlýr:
    Coroutine
    Animator
    Physics
    Scene
    GameObject
    MonoBehaviour
    Frame beklemek
    WaitForSeconds
    Async Unity iþlemleri
    
    }*/

    /*
     * Her test bittikten sonra çalýþýr
    [TearDown]
    public void Cleanup()
    {
    }*/

    /*
     * En son bir kez çalýþýr
    [OneTimeTearDown]
    public void LastCleanup()
    {
    }*/





    /*Test Case Source -> veriyi ayrý bir yerden alýr.*/

    /*    private static readonly object[] TestData =
        {
            new object[]{2,4},
            new object[]{3,9},
            new object[]{4,16},
            new object[]{5,25}
        };

        [TestCaseSource(nameof(TestData))]
        public void Square_ReturnsExpected(
        int input,
        int expected)
        {
            Assert.AreEqual(expected,
                calculator.Square(input));
        }*/



    /*Value Source -> tek parametre varsa kullanýlýr*/
/*
    private static readonly int[] Levels =
    {
        1,
        5,
        10,
        20
    };

    [ValueSource(nameof(Levels))]
    public void Level_ShouldBePositive(int level)
    {
        Assert.Greater(level, 0);
    }*/

}
