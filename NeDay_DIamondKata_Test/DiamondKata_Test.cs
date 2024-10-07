using NewDay_DiamondKata;

namespace NewDay_DIamondKata_Test
{
    [TestFixture]
    public class DiamondKata_Test
    {
        /// <summary>
        /// A StringWriter to capture the console output for testing.
        /// </summary>
        private StringWriter output;

        /// <summary>
        /// Setup method executed before each test. It redirects the console output to the StringWriter.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Redirect output to a StringWriter so we can capture the console output.
            output = new StringWriter();
            Console.SetOut(output);
        }

        /// <summary>
        /// Teardown method executed after each test. It disposes of the StringWriter and resets the console output.
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            // Reset console output back to its original state.
            output.Dispose();
        }

        /// <summary>
        /// Test valid input 'A' should print a single 'A' character as the diamond.
        /// </summary>
        [Test]
        public void TestPrintDiamond_A()
        {
            // Arrange
            char input = 'A';

            // Act
            DiamondKata.PrintDiamond(input);

            // Assert
            string expectedOutput = "A\n";
            Assert.That(NormaliseOutput(output.ToString()), Is.EqualTo(expectedOutput));
        }

        /// <summary>
        /// Test valid input 'B' should print the correct diamond shape with 'A' at the top and 'B' as the midpoint.
        /// </summary>
        [Test]
        public void TestPrintDiamond_B()
        {
            // Arrange
            char input = 'B';

            // Act
            DiamondKata.PrintDiamond(input);

            // Assert
            string expectedOutput = " A\nB B\n A\n";

            Assert.That(NormaliseOutput(output.ToString()), Is.EqualTo(expectedOutput));
        }

        /// <summary>
        /// Test valid input 'C' should print the correct diamond shape with 'A' at the top, 'B' as the next, and 'C' as the midpoint.
        /// </summary>
        [Test]
        public void TestPrintDiamond_C()
        {
            // Arrange
            char input = 'C';

            // Act
            DiamondKata.PrintDiamond(input);

            // Assert
            string expectedOutput = "  A\n B B\nC   C\n B B\n  A\n";
            Assert.That(NormaliseOutput(output.ToString()), Is.EqualTo(expectedOutput));
        }

        /// <summary>
        /// Normalises the output string by replacing Windows-style carriage returns (\r\n) with Unix-style newlines (\n).
        /// </summary>
        /// <param name="output">The captured console output string to normalize.</param>
        /// <returns>Normalised output with consistent newline characters.</returns>
        private string NormaliseOutput(string output)
        {
            return output.ToString().Replace("\r\n", "\n");
        }
    }
}