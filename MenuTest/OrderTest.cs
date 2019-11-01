using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using System.Collections.ObjectModel;

namespace MenuTest
{
    public class OrderTest
    {
        class NegativeMockEntree : Entree
        {
            public NegativeMockEntree()
            {
                this.Price = -1.5;
            }

            public override string ToString()
            {
                return "Entree";
            }
        }

        class MockEntree : Entree
        {
            public MockEntree()
            {
                this.Price = 10.25;
            }

            public override string ToString()
            {
                return "Entree";
            }
        }

        class MockDrink : Drink
        {
            public MockDrink()
            {
                this.Price = 4.45;
            }

            public override string ToString()
            {
                return "Drink";
            }
        }

        class MockSide : Side
        {
            public MockSide()
            {
                this.Price = 3.85;
            }

            public override string ToString()
            {
                return "Side";
            }
        }

        [Fact]
        public void ShouldNotAllowNegativeSubTotalForNegativeMockEntree()
        {
            Order o = new Order();
            o.Add(new NegativeMockEntree());
            Assert.Equal<double>(0, Math.Round(o.SubtotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForMockDrink()
        {
            Order o = new Order();
            o.Add(new MockDrink());
            Assert.Equal<double>(4.45, o.SubtotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForMockEntree()
        {
            Order o = new Order();
            o.Add(new MockEntree());
            Assert.Equal<double>(10.25, Math.Round(o.SubtotalCost, 2));
        }

        [Fact]
        public void ShouldHaveCorrectSubTotalCostForMockSide()
        {
            Order o = new Order();
            o.Add(new MockSide());
            Assert.Equal<double>(3.85, Math.Round(o.SubtotalCost, 2));
        }
    }
}
