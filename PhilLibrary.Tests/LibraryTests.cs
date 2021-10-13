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


    }
  }
}
