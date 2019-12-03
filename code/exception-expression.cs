// try is not an expression
int? a;
try { a = int.Parse(input); }
catch { a = null; }