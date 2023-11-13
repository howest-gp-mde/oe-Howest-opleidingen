using SP.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Tests.Converters
{
    public class LocationToIconConverterTests
    {

        [Fact]
        public void Convert_Valid_Location_ToUrl()
        {
            // Arrange
            LocationToIconConverter converter = new LocationToIconConverter();

            // Act
            string url = (string)converter.Convert("Kortijk", null, null, null);

            // Assert
            Assert.Equal("http", url.ToLower().Substring(0, 4));
        }
    }
}
