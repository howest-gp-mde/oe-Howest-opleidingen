using SP.Domain.Models;
using SP.Domain.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Tests.Validators
{
    public class SettingsValidatorTests
    {
        [Fact]
        public void Validate_CorrectInput_Returns_True()
        {
            // Arrange
            SettingsValidator validator = new SettingsValidator();
            
            Settings settings = new Settings
            {
                Email = "correct@example.com",
                NumberOfCertificates = 2,
                ReceiveWeeklyStats = true,
                UserName = "username"
            };

            // Act
            var result = validator.Validate(settings);

            // Assert
            Assert.True(result.IsValid);

        }

        [Fact]
        public void Validate_NoUserName_Give_ErrorMessage()
        {
            // Arrange
            var validator = new SettingsValidator();
            
            Settings settings = new Settings
            {
                Email = "correct@example.com",
                NumberOfCertificates = 2,
                ReceiveWeeklyStats = true,
                UserName = ""
            };

            // Act
            var result = validator.Validate(settings);
            
            // Assert
            Assert.Equal("Geef een username op !", result.Errors[0]?.ErrorMessage);
        }


    }
}
