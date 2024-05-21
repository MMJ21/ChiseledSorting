using ChiseledSorting;

var myObjects = new List<MyObject>();
for (int i = 1; i <= 50000000; i++)
{
    myObjects.Add(new MyObject
    {
        Id = i,
        Name = $"Object {i}",
        CreationDateTime = DateTime.Now,
    });
}
Console.WriteLine($"Total number of objects: {myObjects.Count}");
Console.WriteLine($"First object on the list is {myObjects.First().Name}");
Console.WriteLine($"Last object on the list is {myObjects.Last().Name}");
Console.WriteLine("Reversing list...");

var result = myObjects.OrderByDescending(o => o.Id).ToList();
Console.WriteLine($"First object on the list is {result.First().Name}");
Console.WriteLine($"Last object on the list is {result.Last().Name}");