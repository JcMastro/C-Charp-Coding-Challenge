namespace C_Charp_Coding_Challenge.test
{
    [TestClass]
    public class UnitTestCodingChallenge
    {
        [TestMethod]
        public void Test_OldPhonePad()
        {
            var numbers = new CodingChallenge();

            string input = "8 88777444666*664#";

            string output = numbers.OldPhonePad(input);
            
            Assert.AreEqual("TURINNG", output);
        }
        [TestMethod]
        public void Test_splitInput()
        {
            var numbers = new CodingChallenge();

            string input = "8 88777444666*664#";

            List<int> result = numbers.splitInput(input);

            List<int> expected = new List<int> { 8, 88, 777, 444, 66, 66, 4};

            Assert.IsTrue(expected.SequenceEqual(result));
        }
        [TestMethod]
        public void Test_convertToCharacters()
        {
            var numbers = new CodingChallenge();

            List<int> numbersList = new List<int> { 8, 88, 777, 444, 66, 66, 4 };

            List<string> output = numbers.convertToCharacters(numbersList);

            List<string> expected = new List<string> { "T", "U", "R", "I", "N", "N", "G"};

            Assert.IsTrue(expected.SequenceEqual(output));
        }
        [TestMethod]
        public void Test_GetLetter()
        {
            var numbers = new CodingChallenge();

            int input = 8;

            string output = numbers.GetLetter(input);

            Assert.AreEqual("T", output);
        }

    }
}