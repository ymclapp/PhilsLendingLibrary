using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PhilLibrary.Tests
{
  public class LibraryTests
  {
    [Fact]
    public void Backpack_starts_empty()
    {

      //Arrange
      Backpack<string> backpack = new Backpack<string>();

      //Act
      //nothing to do - just to see if backpack exists

      //Assert
      Assert.Empty(backpack);
    }//end of Backpack_starts_empty()

    [Fact]
    public void Add_works()
    {

      //Arrange
      Backpack<string> backpack = new Backpack<string>();

      //Act
      backpack.Add("Davinci Code");

      //Assert
      Assert.Equal(
        new[] { "Davinci Code" },
        backpack);
    }//end of the Add_works which adds one item to the backpack

    [Fact]
    public void Add_three_things_to_backpack()
    {
      //Arrange
      Backpack<string> backpack = new Backpack<string>();

      //Act
      backpack.Add("Davinci Code");
      backpack.Add("Angels and Demons");
      backpack.Add("The Last Symbol");

      //Assert
      Assert.Equal(
        new[] { "Davinci Code", "Angels and Demons", "The Last Symbol" },
        backpack);
    }//end of Add_three_things_to_backpack

  }
}
