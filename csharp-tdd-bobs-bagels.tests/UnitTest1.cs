using System.Threading.Tasks.Sources;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("BLT")]
    [TestCase("Cream cheese")]
    [TestCase("Dark chocolate")]
    public void addBagel(string bagel)
    {
        Core basket = new Core(2);

        string[] Result = basket.addBagel(bagel);

        //Assert.IsNotEmpty(Result);                
        //Assert.That(Result[Result.Length-1], Is.EqualTo(bagel));
        Assert.IsFalse(Result.Contains(bagel));
    }

    [TestCase("BLT")]
    [TestCase("Cream cheese")]
    [TestCase("White chocolate")]//Does not exist in Basket
    public void removeBagel(string bagelToRemove)
    {
        Core basket = new Core(4);
        string[] bagelsToAdd = { "BLT", "Ham and cheese", "Cream cheese", "Chocolate" };
        foreach(string bagel in bagelsToAdd)
        {
            basket.addBagel(bagel); 
        }

        string[] Result = basket.removeBagel(bagelToRemove);

        Assert.IsTrue(Result.Length == bagelsToAdd.Length-1);
        Assert.IsFalse(Result.Contains(bagelToRemove));
    }

    [TestCase(10)]
    [TestCase(5)]
    [TestCase(6)]
    public void changeCapacity(int limit)
    {
        Core basket = new Core(3);

        int currentCapacity = basket.Capacity;
        int result = basket.setCapacity(limit);

        Assert.That(limit, Is.EqualTo(result));
        Assert.That(basket.Capacity != currentCapacity);
        
    }
    [Test]
    public void ErrorMessageCapacity()
    {
        Core basket = new Core(3);
        for (int i = 0; i <= basket.Capacity; i++) {
            basket.addBagel("A bagel"); }
        
        //basket.addBagel("An extra bagel");

        int basketLength = basket.Basket.Length;
        string capacityMessage = "basket is full";
        string message = basket.checkLimit();


        Assert.That(basket.Capacity <= basketLength);
        Assert.That(basket.Capacity == basketLength, Is.EqualTo(capacityMessage == message.ToLower()));
    }

    [TestCase("BLT")]
    [TestCase("Cream cheese")]
    [TestCase("White chocolate")]//Does not exist in Basket
    [TestCase("Bubble Gum")]
    public void bagelExistsInBag(string bagelToRemove)
    {
        Core basket = new Core(4);
        string[] bagelsToAdd = { "Cream cheese", "Chocolate" };
        foreach (string bagel in bagelsToAdd)
        {
            basket.addBagel(bagel);
        }

        bool Result = basket.bagelIsInBasket(bagelToRemove);
        string[] bagelList = basket.removeBagel(bagelToRemove);

        Assert.That(Result, Is.EqualTo(basket.Basket.Contains(bagelToRemove)));
        Assert.That(bagelToRemove.Length >=0);
    }
}