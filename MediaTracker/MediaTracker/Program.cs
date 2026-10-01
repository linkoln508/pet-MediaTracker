using MediaTracker;

Movie matrix = new Movie("Matrix", 1999, MediaItem.StatusEnum.Watched, 8.7, "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", new List<string> { "Lana Wachowski", "Lilly Wachowski" }, new List<string> { "Action", "Sci-Fi" }, 136);

Series sherlock = new Series("Sherlock", 2010, MediaItem.StatusEnum.Watched, 9.1, "A modern update finds the famous sleuth and his doctor partner solving crime in 21st century London.", new List<string> { "Steven Moffat", "Mark Gatiss" }, new List<string> { "Crime", "Drama", "Mystery" }, 4, 13);

Console.WriteLine($"Movie: {matrix.NameTitle}, Year: {matrix.ReleaseYear}, Status: {matrix.Status}, Score: {matrix.Score}, Description: {matrix.Description}, Director: {string.Join(", ", matrix.Director)}, Genre: {string.Join(", ", matrix.Genre)}, Duration: {matrix.Duration} minutes");
Console.WriteLine($"Series: {sherlock.NameTitle}, Year: {sherlock.ReleaseYear}, Status: {sherlock.Status}, Score: {sherlock.Score}, Description: {sherlock.Description}, Director: {string.Join(", ", sherlock.Director)}, Genre: {string.Join(", ", sherlock.Genre)}, Seasons: {sherlock.Seasons}, Episodes: {sherlock                                     .Episodes}");