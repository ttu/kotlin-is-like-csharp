var datas = new List&lt;SensorData> 
{
    new SensorData { Id = 1, Location = "A", Value = 2.89 },
    new SensorData { Id = 2, Location = "B", Value = 12.01 },
    new SensorData { Id = 3, Location = "B", Value = 11.89 },
    new SensorData { Id = 4, Location = "A", Value = 3.11 },
    new SensorData { Id = 5, Location = "A", Value = -456.0 }
};

var avgs = datas
            .Where(e => e.Value > -50.0)
            .GroupBy(e => e.Location)
            .Select(g => new { 
                    Location = g.Key,
                    Value = g.Average(e => e.Value) });

// { Location: A, Value: 3.0 }
// { Location: B, Value: 11.95 }