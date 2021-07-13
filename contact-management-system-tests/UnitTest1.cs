using System;
using Xunit;
using contact_management_system;


namespace contact_management_system_tests
{
    public class contactTests
    {
        public class UnitTest1
        {
            // Classes tests
            [Fact]
            public void PersonalContactTestFirstName()
            {
                // Arrange
                PersonalContact persConn = new contact_management_system.PersonalContact("1", "First Name", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test");

                // Act
                string output = persConn.ContactFName;

                //Assert
                Assert.Equal("First Name", output);
            }

            [Fact]
            public void PersonalContactTestContactCityGetSet()
            {
                // Arrange
                Contact contact = new contact_management_system.Contact("1", "First Name", "LastName", "Email", "Tel", "Address 1", "Address 2", "City", "Postcode");

                // Act
                contact.ContactCity = "Coventry";

                //Assert
                Assert.Equal("Coventry", contact.ContactCity);
            }

            [Fact]
            public void dbConnTestconnOpen()
            {
                // Arrange

                contact_management_system.dbConn.personalDbConn mysqlConn;
                mysqlConn = new contact_management_system.dbConn.personalDbConn();
                mysqlConn.connect();


                // Act
                bool connected = mysqlConn.connOpen();

                // Assert
                Assert.True(connected);
            }


        }
    }
}
