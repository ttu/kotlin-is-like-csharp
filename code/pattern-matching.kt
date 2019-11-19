val nb = 42
val text = when (nb) {
    in 0..7, 8, 9 -> "single digit"
    10 -> "double digits"
    in 11..99 -> "double digits"
    in 100..999 -> "triple digits"
    else -> "four or more digits"
}
// double digits