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
        Core basket = new Core();

        string[] Result = basket.addBagel(bagel);

        Assert.IsNotEmpty(Result);                
        Assert.That(bagel == Result[Result.Length-1]);
        Assert.That(Result.Contains(bagel));
    }

    [TestCase("BLT")]
    [TestCase("Cream cheese")]
    [TestCase("White chocolate")]//Does not exist in Basket
    public void removeBagel(string bagelToRemove)
    {
        Core basket = new Core();
        string[] bagelsToAdd = { "BLT", "Ham and cheese", "Cream cheese", "Chocolate" };
        foreach(string bagel in bagelsToAdd)
        {
            basket.addBagel(bagel); 
        }

        string[] Result = basket.removeBagel(bagelToRemove);

        Assert.IsTrue(Result.Length == bagelsToAdd.Length-1);
        Assert.IsFalse(Result.Contains(bagelToRemove));
    }
}