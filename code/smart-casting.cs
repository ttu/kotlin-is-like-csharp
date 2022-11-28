foreach (var current in library)
{
    if (current is Movie movie)
    {
        Console.WriteLine($"Movie: '{movie.Name}', " +
	    $"dir: {movie.Director}");
    }
}
