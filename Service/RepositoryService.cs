using ListViewDemo.Model;
using System.Collections.ObjectModel;

namespace ListViewDemo.Service
{
    public static class RepositoryService
    {
        internal static ObservableCollection<Book> GetBooks()
        {
            var bookList = new List<Book>()
            {
                new Book()
                {
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Publisher = "J. B. Lippincott & Co.",
                    PublicationDate = new DateTime(1960, 7, 11),
                    Genre = "Fiction, Classic"
                },
                new Book()
                {
                    Title = "1984",
                    Author = "George Orwell",
                    Publisher = "Secker & Warburg",
                    PublicationDate = new DateTime(1949, 6, 8),
                    Genre = "Fiction, Dystopian"
                },
                new Book()
                {
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Publisher = "T. Egerton, Whitehall",
                    PublicationDate = new DateTime(1813, 1, 28),
                    Genre = "Fiction, Classic, Romance"
                },
                new Book()
                {
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Publisher = "Charles Scribner's Sons",
                    PublicationDate = new DateTime(1925, 4, 10),
                    Genre = "Fiction, Classic"
                },
                new Book()
                {
                    Title = "To the Lighthouse",
                    Author = "Virginia Woolf",
                    Publisher = "Hogarth Press",
                    PublicationDate = new DateTime(1927, 5, 5),
                    Genre = "Fiction, Modernist"
                },
                new Book()
                {
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    Publisher = "Chatto & Windus",
                    PublicationDate = new DateTime(1932, 10, 17),
                    Genre = "Fiction, Dystopian"
                },
                new Book()
                {
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    Publisher = "Little, Brown and Company",
                    PublicationDate = new DateTime(1951, 7, 16),
                    Genre = "Fiction, Coming-of-Age"
                },
                new Book()
                {
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Publisher = "George Allen & Unwin",
                    PublicationDate = new DateTime(1937, 9, 21),
                    Genre = "Fiction, Fantasy"
                },
                new Book()
                {
                    Title = "Frankenstein",
                    Author = "Mary Shelley",
                    Publisher = "Lackington, Hughes, Harding, Mavor & Jones",
                    PublicationDate = new DateTime(1818, 1, 1),
                    Genre = "Fiction, Horror"
                },
                new Book()
                {
                    Title = "Jane Eyre",
                    Author = "Charlotte Brontë",
                    Publisher = "Smith, Elder & Co.",
                    PublicationDate = new DateTime(1847, 10, 16),
                    Genre = "Fiction, Gothic, Romance"
                },
                new Book()
                {
                    Title = "The Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    Publisher = "George Allen & Unwin",
                    PublicationDate = new DateTime(1954, 7, 29),
                    Genre = "Fiction, Fantasy"
                },
                new Book()
                {
                    Title = "The Chronicles of Narnia",
                    Author = "C.S. Lewis",
                    Publisher = "Geoffrey Bles",
                    PublicationDate = new DateTime(1950, 10, 16),
                    Genre = "Fiction, Fantasy"
                },
                new Book()
                {
                    Title = "Moby-Dick",
                    Author = "Herman Melville",
                    Publisher = "Richard Bentley",
                    PublicationDate = new DateTime(1851, 10, 18),
                    Genre = "Fiction, Adventure"
                },
                new Book()
                {
                    Title = "The Adventures of Tom Sawyer",
                    Author = "Mark Twain",
                    Publisher = "Chatto & Windus",
                    PublicationDate = new DateTime(1876, 12, 1),
                    Genre = "Fiction, Adventure"
                },
                new Book()
                {
                    Title = "The Odyssey",
                    Author = "Homer",
                    Publisher = "Various ancient publishers",
                    PublicationDate = new DateTime(800, 1, 1),
                    Genre = "Poetry, Epic"
                },
                new Book()
                {
                    Title = "The Picture of Dorian Gray",
                    Author = "Oscar Wilde",
                    Publisher = "Ward, Lock and Company",
                    PublicationDate = new DateTime(1890, 6, 20),
                    Genre = "Fiction, Gothic"
                },
                new Book()
                {
                    Title = "Sense and Sensibility",
                    Author = "Jane Austen",
                    Publisher = "Thomas Egerton",
                    PublicationDate = new DateTime(1811, 10, 30),
                    Genre = "Fiction, Classic, Romance"
                },
                new Book()
                {
                    Title = "Wuthering Heights",
                    Author = "Emily Brontë",
                    Publisher = "Thomas Cautley Newby",
                    PublicationDate = new DateTime(1847, 12, 1),
                    Genre = "Fiction, Gothic, Romance"
                },
                new Book()
                {
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    Publisher = "HarperCollins",
                    PublicationDate = new DateTime(1988, 1, 1),
                    Genre = "Fiction, Inspirational"
                },
                new Book()
                {
                    Title = "The Kite Runner",
                    Author = "Khaled Hosseini",
                    Publisher = "Riverhead Books",
                    PublicationDate = new DateTime(2003, 5, 29),
                    Genre = "Fiction, Historical"
                },
                new Book()
                {
                    Title = "The Book Thief",
                    Author = "Markus Zusak",
                    Publisher = "Picador",
                    PublicationDate = new DateTime(2005, 1, 1),
                    Genre = "Fiction, Historical"
                },
                new Book()
                {
                    Title = "The Hunger Games",
                    Author = "Suzanne Collins",
                    Publisher = "Scholastic Corporation",
                    PublicationDate = new DateTime(2008, 9, 14),
                    Genre = "Fiction, Dystopian"
                },
                new Book()
                {
                    Title = "Gone Girl",
                    Author = "Gillian Flynn",
                    Publisher = "Crown Publishing Group",
                    PublicationDate = new DateTime(2012, 6, 5),
                    Genre = "Fiction, Thriller"
                },
                new Book()
                {
                    Title = "The Da Vinci Code",
                    Author = "Dan Brown",
                    Publisher = "Doubleday",
                    PublicationDate = new DateTime(2003, 3, 18),
                    Genre = "Fiction, Mystery"
                },
                new Book()
                {
                    Title = "The Girl on the Train",
                    Author = "Paula Hawkins",
                    Publisher = "Riverhead Books",
                    PublicationDate = new DateTime(2015, 1, 13),
                    Genre = "Fiction, Thriller"
                },
                new Book()
                {
                    Title = "The Help",
                    Author = "Kathryn Stockett",
                    Publisher = "Amy Einhorn Books",
                    PublicationDate = new DateTime(2009, 2, 10),
                    Genre = "Fiction, Historical"
                },
                new Book()
                {
                    Title = "The Fault in Our Stars",
                    Author = "John Green",
                    Publisher = "Dutton Books",
                    PublicationDate = new DateTime(2012, 1, 10),
                    Genre = "Fiction, Young Adult"
                },
                new Book()
                {
                    Title = "The Maze Runner",
                    Author = "James Dashner",
                    Publisher = "Delacorte Press",
                    PublicationDate = new DateTime(2009, 10, 6),
                    Genre = "Fiction, Young Adult, Dystopian"
                },
                new Book()
                {
                    Title = "The Girl with the Dragon Tattoo",
                    Author = "Stieg Larsson",
                    Publisher = "Norstedts Förlag",
                    PublicationDate = new DateTime(2005, 8, 1),
                    Genre = "Fiction, Crime, Thriller"
                },
                new Book()
                {
                    Title = "The Handmaid's Tale",
                    Author = "Margaret Atwood",
                    Publisher = "McClelland and Stewart",
                    PublicationDate = new DateTime(1985, 1, 1),
                    Genre = "Fiction, Dystopian"
                }
            };

            return new ObservableCollection<Book>(bookList.OrderBy(c => c.Title));
        }
    }
}
