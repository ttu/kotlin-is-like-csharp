// try is an expression, i.e. it may have a return value
val a: Int? = try { input.toInt() } 
              catch (e: NumberFormatException) { null }