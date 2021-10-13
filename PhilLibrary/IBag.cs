using System;
using System.Collections;
using System.Collections.Generic;

namespace PhilLibrary
{
  public interface IBag<T> : IEnumerable<T>
  {
    /// <summary>
    /// Add an item to the bag. <c>null</c> items are ignored.
    /// </summary>
    void Pack(T item);

    /// <summary>
    /// Remove the item from the bag at the given index.
    /// </summary>
    /// <returns>The item that was removed.</returns>
    T Unpack(int index);
  }
  public class Backpack<T> : IBag<T>
  {
    T[] books = new T[10];
    int count = 0;
    public int Count => count;
    public void Add(T value)
    {
      books[count] = value;
      count++;
    }

    public IEnumerator<T> GetEnumerator()
    {
      //Use iterator to return empty(for now)
      //yield break;

      for (int i = 0; i < count; i++)
      {
        yield return books[i];
      }
    }

    public void Pack(T item)
    {
      throw new NotImplementedException();
    }

    public T Unpack(int index)
    {
      throw new NotImplementedException();
    }

    //Explicit implementation of the interface member
    IEnumerator IEnumerable.GetEnumerator()
    {
      //Call the real one above
      return GetEnumerator();
    }
  }
}

