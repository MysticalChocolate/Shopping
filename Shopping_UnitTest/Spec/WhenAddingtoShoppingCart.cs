using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;
using Shopping.source;

namespace Shopping_UnitTest.Spec
{
    public class WhenAddingtoShoppingCart
    {
        private readonly Item _item = new Item("test", .01);
        private Cart _cart = new Cart();
        public WhenAddingtoShoppingCart()
        {
            // var  _cartController = new CartController();
            // _cart = _cartController.Add(_item);
            _cart.Add(_item);
            /*for (int i = 0; i < 10; i++)
                _cartController.Add(_item);*/

        }

        [Fact]
        public void ThenItemIsExpected()
        {
            using var scope = new AssertionScope();
            _cart.Items.Should().NotBeEmpty().And.HaveCount(1);
            _cart.Items.Should().Contain(_item);
        }

       /* [Fact]
        public void CanNotExceedCartLimit()
        {
            _cart.items.Should().HaveSameCount(10);
        }*/

    }
}
