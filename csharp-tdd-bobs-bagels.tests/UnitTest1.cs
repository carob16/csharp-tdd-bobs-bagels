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
        int lengthBeforeAdded = basket.Basket.Count;

        List<string> Result = basket.addBagel(bagel);

        Assert.IsTrue(Result.Contains(bagel));
        Assert.That(Result.Count >= lengthBeforeAdded);
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

        KeyValuePair<string, bool> IsInList = basket.bagelIsInBasket(bagelToRemove);
        List<string> Result = basket.removeBagel(bagelToRemove);
       
        Assert.That(Result.Count == bagelsToAdd.Length-1, Is.EqualTo(IsInList.Value));
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
        
        List<string> extraBagel = basket.addBagel("An extra bagel");

        int basketLength = basket.Basket.Count;
        bool isNotFull = basket.checkBasketLimit();


       Assert.That(basket.Capacity == basketLength);
       Assert.That(basket.Capacity == basketLength, Is.EqualTo(isNotFull == false));
        Assert.That(false == extraBagel.Contains("An extra bagel"));
    }

    [TestCase("BLT")]
    [TestCase("Cream cheese")]
    [TestCase("White chocolate")]//Does not exist in Basket
    [TestCase("Bubble Gum")]
    public void bagelExistsInBag(string bagelToRemove)
    {
        Core basket = new Core(4);
        List<string> bagelsToAdd = [ "Cream cheese", "Chocolate", "BLT" ];
        foreach (string bagel in bagelsToAdd)
        {
            basket.addBagel(bagel);
        }
        Assert.That(basket.Basket.Count, Is.EqualTo(bagelsToAdd.Count));
        KeyValuePair<string,bool> Result = basket.bagelIsInBasket(bagelToRemove);
            
        Assert.That(Result.Value == true, Is.EqualTo(Result.Key == bagelToRemove));
          
    }
}