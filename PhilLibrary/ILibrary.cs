using System.Collections.Generic;

namespace PhilLibrary
{
  public interface ILibrary : IReadOnlyCollection<Book>
  {
    /// <summary>
    /// Add a Book to the library.
    /// </summary>
    void Add(string title, string firstName, string lastName, string genre, int numberOfPages);

    /// <summary>
    /// Remove a Book from the library with the given title.
    /// </summary>
    /// <returns>The Book, or null if not found.</returns>
    Book Borrow(string title);

      /// <summary>
      /// Return a Book to the library.
      /// </summary>
      void Return(Book book);

      public interface IBag<T> : IEnumerable<T>
      {
        /// <summary>
        /// Add an item to the bag. <c>null</c> items are ignored.
        /// </summary>
        Backpack<T> backpack = new Backpack<T>();
        

        void Pack(T item);

        /// <summary>
        /// Remove the item from the bag at the given index.
        /// </summary>
        /// <returns>The item that was removed.</returns>
        T Unpack(int index);
      }
    }

}

