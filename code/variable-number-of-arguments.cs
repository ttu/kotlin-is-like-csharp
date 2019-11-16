int SumOf(params int[] numbers)
{
    var sum = 0;
    foreach (var number in numbers) 
        sum += number;
    return sum;
}

var sum = SumOf(42, 597, 12);

// SumOf() can also be written in a shorter way:
int SumOf(params int[] numbers) => numbers.Sum();