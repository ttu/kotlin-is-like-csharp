try {
    // some code
}
catch (e: SomeException) {
    if (e.SomeCode == 404) {
        // handle SomeException when SomeCode is 404
    } else {
        // handle SomeException
    }
}
catch (e: Exception) {
    // handle rest of the Exceptions
}
finally {
    // optional finally block
}