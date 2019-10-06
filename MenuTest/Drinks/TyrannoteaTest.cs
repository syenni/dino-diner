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
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }

        //The correct price and calories after changing to small, medium, and large
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            if (tea.Sweet == true)
                Assert.Equal<uint>(16, tea.Calories);
            else
                Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            if (tea.Sweet == true)
                Assert.Equal<uint>(32, tea.Calories);
            else
                Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrecCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            if (tea.Sweet == true)
                Assert.Equal<uint>(64, tea.Calories);
            else
                Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveChangedIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
            Assert.DoesNotContain<string>("Lemon", tea.Ingredients);
        }

        [Fact]
        public void ShouldHaveChangedLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
            Assert.Contains<string>("Lemon", tea.Ingredients);
        }
    }
}
