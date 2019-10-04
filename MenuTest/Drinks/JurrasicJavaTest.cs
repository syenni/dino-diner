using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<double>(0.59, coffee.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<uint>(2, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Contains<string>("Water", coffee.Ingredients);
            Assert.Contains<string>("Coffee", coffee.Ingredients);
            Assert.Equal<int>(2, coffee.Ingredients.Count);
        }

        //The correct price and calories after changing to small, medium, and large
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Small;
            Assert.Equal<double>(0.59, coffee.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(0.99, coffee.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Small;
            Assert.Equal<uint>(2, coffee.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<uint>(4, coffee.Calories);
        }
        [Fact]
        public void ShouldHaveCorrecCaloriesForLarge()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.Size = Size.Large;
            Assert.Equal<uint>(8, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveChangedIce()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.False(coffee.Ice);
        }
    }
}
