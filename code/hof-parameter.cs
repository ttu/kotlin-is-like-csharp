string Transform(string initial, Func&lt;string, string> f) => f(initial);

var result = Transform("hello", x => x.ToUpper());
// HELLO