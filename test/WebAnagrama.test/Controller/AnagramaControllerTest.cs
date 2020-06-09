using WebAnagrama.Controllers;
using Xunit;

namespace WebAnagrama.Tests.API
{
    public class AnagramaControllerTest
    {
        private AnagramaController _controller;

        public AnagramaControllerTest()
        {
            _controller = new AnagramaController();
        }

        [Theory]
        [InlineData("amor","roma", true)]
        [InlineData("wrong-user", "wrrong", false)]
        public async void Get_Should_If_Strings_Are_Anagram(string first, string second, bool expect)
        {
            var response = _controller.Get(first, second);

            Assert.Equal(response, expect);
        }

    }
}