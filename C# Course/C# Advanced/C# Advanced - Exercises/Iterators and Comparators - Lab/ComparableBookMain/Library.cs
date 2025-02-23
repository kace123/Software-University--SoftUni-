﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ComparableBookMain
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;

        public Library(params Book[] _books)
        {
            this.books = new SortedSet<Book>(_books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public Book Current => this.books[currentIndex];
            object IEnumerator.Current => this.Current;
            public void Dispose() { }
            public bool MoveNext() => ++this.currentIndex < books.Count;
            public void Reset() => this.currentIndex = -1;

        }
    }
}
