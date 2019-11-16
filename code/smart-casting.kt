for (current in library) {
    if (current is Movie) {
        println("Movie: '${current.name}', " +
	    "dir. ${current.director}")
    }
}
