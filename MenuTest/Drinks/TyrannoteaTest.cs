using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannpteaTest
    {
        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyranntea tea = new Tyranntea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyranntea tea = new Tyranntea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyranntea tea = new Tyranntea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }

        //The correct price and calories after changing to small, medium, and large
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyranntea tea = new Tyranntea();
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyranntea tea = new Tyranntea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyranntea tea = new Tyranntea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyranntea tea = new Tyranntea();
            tea.Size = Size.Small;
            if (tea.Sweet == true)
                Assert.Equal<uint>(16, tea.Calories);
            else
                Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyranntea tea = new Tyranntea();
            tea.Size = Size.Medium;
            if (tea.Sweet == true)
                Assert.Equal<uint>(32, tea.Calories);
            else
                Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrecCaloriesForLarge()
        {
            Tyranntea tea = new Tyranntea();
            tea.Size = Size.Large;
            if (tea.Sweet == true)
                Assert.Equal<uint>(64, tea.Calories);
            else
                Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveChangedIce()
        {
            Tyranntea tea = new Tyranntea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyranntea tea = new Tyranntea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyranntea tea = new Tyranntea();
            Assert.False(tea.Lemon);
            Assert.DoesNotContain<string>("Lemon", tea.Ingredients);
        }

        [Fact]
        public void ShouldHaveChangedLemon()
        {
            Tyranntea tea = new Tyranntea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
            Assert.Contains<string>("Lemon", tea.Ingredients);
        }
    }
}
