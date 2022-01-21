using System;
using System.Threading.Tasks;
using Italbytz.Ports.Meal;
using NUnit.Framework;

namespace Italbytz.Adapters.Meal.Mock.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task TestDataSource()
    {
        var dataSource = new MockMealDataSource();
        var meals = await dataSource.RetrieveAll();
        Assert.AreEqual(3, meals.Count);
    }

    [Test]
    public async Task TestGetMealsService()
    {
        var service = new MockGetMealsService();
        var query = new MockMealQuery() { Mensa = 42, Date = DateTime.Now };
        var meals = await service.Execute(query);
        Assert.AreEqual(2, meals.Count);
    }
}

internal class MockMealQuery : IMealQuery
{
    public MockMealQuery()
    {
    }

    public int Mensa { get; set; }
    public DateTime Date { get; set; }
}

