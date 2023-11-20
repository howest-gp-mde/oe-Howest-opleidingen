using SP.Services.Mock;
using SP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Tests.ViewModels
{
    public  class StudyProgrammesViewModelTests
    {
        [Fact]
        public async void Init_Normal_StudyProgrammesNotEmptyAsync()
        {
            // Arrange
            var service = new StudyProgrammeMockService();
            var model = new StudyProgrammesViewModel(service);
            

            // Act
            model.Init(null);

            await Task.Delay(3000);
            // Assert
            Assert.NotNull(model.StudyProgrammes);
            Assert.NotEmpty(model.StudyProgrammes);
            
        }
    }
}
