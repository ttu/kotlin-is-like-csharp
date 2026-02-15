// LINQ is lazy, so no need to use other collection types
var query = new List&lt;int> { 1, 2, 3, 4 }
        .Where(i =>
        {
            Console.WriteLine($"Filter {i}, ");
            return i % 2 == 1;
        }).Select(i =>
        {
            Console.WriteLine($"Map {i}, ");
            return i * 2;
        });


var items = query.ToList();

//Filter 1,
//Map 1,
//Filter 2,
//Filter 3,
//Map 3,
//Filter 4,