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
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<double>(0.59, coffee.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<uint>(2, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Contains<string>("Water", coffee.Ingredients);
            Assert.Contains<string>("Coffee", coffee.Ingredients);
            Assert.Equal<int>(2, coffee.Ingredients.Count);
        }

        //The correct price and calories after changing to small, medium, and large
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            Assert.Equal<double>(0.59, coffee.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(0.99, coffee.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            Assert.Equal<uint>(2, coffee.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<uint>(4, coffee.Calories);
        }
        [Fact]
        public void ShouldHaveCorrecCaloriesForLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<uint>(8, coffee.Calories);
        }

        [Fact]
        public void ShouldHaveChangedIce()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.False(coffee.Ice);
        }
    }
}
