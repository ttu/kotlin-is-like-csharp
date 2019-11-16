public static class Extensions 
{
    public static void Swap(this List&lt;int> list, int idx1, int idx2)
    {
        var temp = list[idx1];
        list[idx1] = list[idx2];
        list[idx2] = temp;
    }
}

var list = new List&lt;int> { 1, 5, 3 };
list.Swap(0, 2);
// [ 3, 5, 1 ]
