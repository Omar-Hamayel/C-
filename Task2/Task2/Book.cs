namespace Taske2
{
    internal class Book
    {
        public Book(int id, string title, string authorName)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
            IsAvailable = true;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool IsAvailable { get; set; }

        public void DisplayInfo() {
            string status = IsAvailable ? "Available" : "Borrowed";
            Console.WriteLine($"ID: {Id}, Title: {Title}, Author: {AuthorName}, Status: {status}");

        }
    }
}
