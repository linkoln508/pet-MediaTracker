using MediaTracker;

Movie matrix = new Movie("Matrix", 1999, MediaItem.StatusEnum.Watched, 8.7, "Балдеж про Нео", new List<string> { "Lana Wachowski", "Lilly Wachowski" }, new List<string> { "Action", "Sci-Fi" }, 136);

Series sherlock = new Series("Sherlock", 2010, MediaItem.StatusEnum.Watched, 9.1, "Балдеж про Шерлока Холмса", new List<string> { "Steven Moffat", "Mark Gatiss" }, new List<string> { "Crime", "Drama", "Mystery" }, 4, 13);

List<MediaItem> mediaItems = new List<MediaItem> { matrix, sherlock };
foreach (var item in mediaItems)
{
    Console.WriteLine(item.GetInfo());
}