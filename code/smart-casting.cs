foreach (var current in library)
{
    if (current is Movie movie)
    {
        Console.WriteLine($"Movie: '{movie.name}', " +
	    $"dir. {movie.director}");
    }
}
