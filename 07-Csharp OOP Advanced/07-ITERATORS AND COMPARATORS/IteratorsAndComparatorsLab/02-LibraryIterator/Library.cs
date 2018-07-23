using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Library : IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = books.ToList();
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }


    private class LibraryIterator : IEnumerator<Book>
    {
        public Book Current => this.books[this.Index];

        object IEnumerator.Current => this.Current;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        private int Index;

        private List<Book> books;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            this.Index++;
            if (this.Index>this.books.Count)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this.Index = -1;
        }
    }
}

