using MediaTracker;

Movie matrix = new Movie("Matrix", 1999, MediaItem.StatusEnum.Watched, 8.7, "Балдеж про Нео", new List<string> { "Lana Wachowski", "Lilly Wachowski" }, new List<string> { "Action", "Sci-Fi" }, 136);

Series sherlock = new Series("Sherlock", 2010, MediaItem.StatusEnum.Watched, 9.1, "Балдеж про Шерлока Холмса", new List<string> { "Steven Moffat", "Mark Gatiss" }, new List<string> { "Crime", "Drama", "Mystery" }, 4, 13);

Movie bladeRunner = new Movie("Blade Runner", 1982, MediaItem.StatusEnum.Watched, 3, "Калл про бегущего по кибер-нью-йорку", new List<string> { "Ridley Scott" }, new List<string> { "Action", "Sci-Fi" }, 117);

List<MediaItem> mediaItems = new List<MediaItem> { matrix, sherlock, bladeRunner };
foreach (var item in mediaItems)
{
    Console.WriteLine(item.GetInfo());
}

try
{
    bladeRunner.Rate(11);
    Console.WriteLine($"Новая Оценка фильмеца {bladeRunner.NameTitle}: {bladeRunner.Score}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

try
{
    sherlock.Rate(9.9);
    Console.WriteLine($"Новая Оценка сериала {sherlock.NameTitle}: {sherlock.Score}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}