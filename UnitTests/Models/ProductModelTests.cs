using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json.Serialization;
using System.Text.Json;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_Get_Id_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNull(result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Id_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Id = "testId";

            // Assert
            Assert.AreEqual("testId", data.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Maker = "testMaker";

            // Assert
            Assert.AreEqual("testMaker", data.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Image = "testImage";

            // Assert
            Assert.AreEqual("testImage", data.Image);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Url = "testUrl";

            // Assert
            Assert.AreEqual("testUrl", data.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Title = "testTitle";

            // Assert
            Assert.AreEqual("testTitle", data.Title);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Description = "testDescription";

            // Assert
            Assert.AreEqual("testDescription", data.Description);
        }

        [TestMethod]
        public void ProductModel_Set_DateTime_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Date = DateTime.UtcNow;

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), data.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Sequence = "testSequence";

            // Assert
            Assert.AreEqual("testSequence", data.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Email = "testEmail";

            // Assert
            Assert.AreEqual("testEmail", data.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Logistics = "testLogistics";

            // Assert
            Assert.AreEqual("testLogistics", data.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Ratings[0] = 3;

            // Assert
            Assert.AreEqual(3, data.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_Constructor_Default_ToString_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            
            // Act
            var result = data.ToString();
            

            // Assert
            Assert.AreEqual(JsonSerializer.Serialize(data), result);
        }

        [TestMethod]
        public void ProductModel_Constructor_AverageRating_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.AverageRating();


            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ProductModel_Constructor_AverageRating_EmptyRatings_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = null;

            // Act
            var result = data.AverageRating();


            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ProductModel_Constructor_AverageRating_ThreeRatings_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = new int[] { 2, 3, 7 };

            // Act
            var result = data.AverageRating();


            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void ProductModel_Constructor_AverageRating_ZeroCount_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = new int[] {};

            // Act
            var result = data.AverageRating();


            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ProductModel_Constructor_AverageRating_ZeroTotal_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = new int[] {-1, 1 };

            // Act
            var result = data.AverageRating();


            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
