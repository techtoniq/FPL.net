using FluentAssertions;
using NUnit.Framework;
using FPL.Extensions;

namespace FPL.UnitTest.Extensions
{
    public class StringExtensionTests
    {
        public class ToSnakeCase
        {
            [Test]
            public void When_Source_String_Is_Empty_Return_Empty()
            {
                string source = string.Empty;

                var result = source.ToSnakeCase();

                result.Should().Be(string.Empty);
            }

            [Test]
            public void When_Source_String_Is_CamelCase_Return_SnakeCase()
            {
                string source = "HereIsAStringWithSomeWordsInIt";

                var result = source.ToSnakeCase();

                result.Should().Be("here_is_a_string_with_some_words_in_it");
            }
        }
    }
}
