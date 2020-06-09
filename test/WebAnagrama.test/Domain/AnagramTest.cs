using Xunit;

namespace WebAnagrama.Tests.Domain
{
    public class AnagramTest
    {
        private Anagram _anagram;

        public AnagramTest()
        {
            _anagram = new Anagram();
        }

        [Theory]
        [InlineData("amor", "roma", true)]
        [InlineData("wrong-user", "wrrong", false)]
        [InlineData("wrongg", "wrrong", false)]

        public void Get_Should_If_Strings_Are_Anagra(string first, string second, bool expect)
        {
            var response = _anagram.areAnagram(first, second);

            Assert.Equal(response.Valid, expect);
        }

        [Fact]
        public void Get_Should_are_anagram()
        {
            var response = _anagram.areAnagram("amor", "roma");

            Assert.Equal("Both string are anagram string.", response.Result);
        }
    }
}