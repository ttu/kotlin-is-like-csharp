Func&lt;int, int> MakeIncrementer()
{
    int addOne(int number) => 1 + number;
    return addOne;
}

var increment = MakeIncrementer();
var result = increment(7);

// MakeIncrementer can also be written in a shorter way:
Func&lt;int, int> MakeIncrementer() => i => 1 + i;
