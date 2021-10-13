using System;
using System.Collections.Generic;

namespace PhilLibrary
{
  public interface ILibrary : IReadOnlyCollection<Book>
  {
    /// <summary>
    /// Add a Book to the library.
    /// </summary>
    public void Add(string title, string firstName, string lastName, string genre, int numberOfPages);

    /// <summary>
    /// Remove a Book from the library with the given title.
    /// </summary>
    /// <returns>The Book, or null if not found.</returns>
    Book Borrow(string title);

      /// <summary>
      /// Return a Book to the library.
      /// </summary>
      void Return(Book book);
    }

}

