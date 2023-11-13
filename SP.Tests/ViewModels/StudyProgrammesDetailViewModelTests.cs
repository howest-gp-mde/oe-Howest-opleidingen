using SP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Tests.ViewModels
{
    public  class StudyProgrammesDetailViewModelTests
    {
        [Fact]
        public void Init_EmptyData_ThrowsException()
        {
            // Arrange
            StudyProgrammeDetailViewModel model = new StudyProgrammeDetailViewModel();

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => model.Init(null));
        }
    }
}
