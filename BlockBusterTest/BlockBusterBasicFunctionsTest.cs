using BlockBuster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BlockBusterTest
{
    public class BlockBusterBasicFunctionsTest
    {
        [Fact]
        public void GetMovieByIdTest()
        {
            var result = BlockBusterBasicFunctions.GetMovieById(11);
            Assert.True(result.Title == "Vertigo");
            Assert.True(result.ReleaseYear == 1958);
        }

        [Fact]
        public void GetAllMovies()
        {
            var result = BlockBusterBasicFunctions.GetAllMovies();
            Assert.True(result.Count == 54);
        }

        [Fact]
        public void GetAllCheckedOutMovies()
        {
            var result = BlockBusterBasicFunctions.GetAllCheckedOutMovies();
            Assert.True(result.Count == 3);
        }

        [Fact]
        public void GetAllMoviesByGenreDescription()
        {
            var result = BlockBusterBasicFunctions.GetAllMoviesByGenreDescription("Drama");
            Assert.True(result.Any());
        }

        [Fact]
        public void GetAllMoviesByDirectorLastName()
        {
            var result = BlockBusterBasicFunctions.GetAllMoviesByDirectorLastName("Darabont");
            Assert.True(result.Any());
        }

        [Fact]
        public void GetMovieByTitle()
        {
            var result = BlockBusterBasicFunctions.GetMovieByTitle("Amadeus");
            Assert.NotNull(result);
            Assert.Equal("Amadeus", result.Title);
            Assert.Equal(1984, result.ReleaseYear);
        }

    }
}
