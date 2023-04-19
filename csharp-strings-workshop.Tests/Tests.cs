using csharp_strings_workshop.Main;
using NUnit.Framework;

namespace csharp_strings_workshop.Tests
{
    
    public class Tests
    {
        StringSamples _stringSamples;
        private readonly string _name = "Albert Einstein"; 
        public Tests()
        {
            _stringSamples = new StringSamples();
            
        }
        [TestCase]
        public void TestStrings()
        {
            Assert.IsTrue(_name == _stringSamples.StringInterpolationExample());
            Assert.IsTrue(_name == _stringSamples.StringBuilderExample());
            Assert.IsTrue(_name == _stringSamples.JoinExample());
            Assert.IsTrue(_name == _stringSamples.ConcatExample());
            Assert.IsTrue(_name == _stringSamples.PlusOperatorExample());
            Assert.IsTrue(_name == _stringSamples.FormatExample());
        }
    }
}