namespace ConverterTests
{
    public class ConverterTests
    {
        private static void RemoveDirectoryContents(string directoryPath)
        {
            try
            {
                if (Directory.Exists(directoryPath))
                {
                    foreach (string file in Directory.GetFiles(directoryPath))
                    {
                        File.Delete(file);
                    }

                    foreach (string subDirectory in Directory.GetDirectories(directoryPath))
                    {
                        Directory.Delete(subDirectory, true);
                    }

                    Console.WriteLine("Directory cleared successfully.");
                }
                else
                    Console.WriteLine("Directory does not exist.");
            }
            catch (Exception)
            {
                return;
            }
        }

        private static void ClearOutputDirectories()
        {
            var pre = Directory.GetCurrentDirectory();
            var out1 = "/outputEmpty";
            var out2 = "/outputText";

            var out1Dir = Path.Combine(pre, out1);
            var out2Dir = Path.Combine(pre, out2);

            RemoveDirectoryContents(out1Dir);
            RemoveDirectoryContents(out2Dir);
        }

        [Fact]
        public void OutputEmptyMultiple()
        {
            ClearOutputDirectories();

            var convert = new Converter.Convert();
            var testFilesDir = "C:\\Programming\\DocxOdt\\DocxOdt\\desktop\\Converter\\ConverterTests\\testFilesEmpty";
            var outputDir = "C:\\Programming\\DocxOdt\\DocxOdt\\desktop\\Converter\\ConverterTests\\outputEmpty";
            
            convert.ChangeInputDirectory(testFilesDir);
            convert.ChangeOutputDirectory(outputDir);

            convert.DocxToOdtMultiple();

            var outputCount = Directory
                .GetFiles(outputDir)
                .Length;

            var testCount = Directory
                .GetFiles(testFilesDir)
                .Length;

            Assert.True(outputCount == testCount);
            Assert.True(outputCount == testCount);
        }

        [Fact]
        public void OutputNotEmptyMultiple()
        {
            ClearOutputDirectories();

            var convert = new Converter.Convert();
            var testFilesDir = "C:\\Programming\\DocxOdt\\DocxOdt\\desktop\\Converter\\ConverterTests\\testFilesText";
            var outputDir = "C:\\Programming\\DocxOdt\\DocxOdt\\desktop\\Converter\\ConverterTests\\outputText";

            convert.ChangeInputDirectory(testFilesDir);
            convert.ChangeOutputDirectory(outputDir);

            convert.DocxToOdtMultiple();

            var outputCount = Directory
                .GetFiles(outputDir)
                .Length;

            var testCount = Directory
                .GetFiles(testFilesDir)
                .Length;

            Assert.True(outputCount == testCount);
        }

        [Fact]
        public void OutputNotEmptyMultipleDoc()
        {
            ClearOutputDirectories();

            var convert = new Converter.Convert();
            var testFilesDir = "C:\\Programming\\DocxOdt\\DocxOdt\\desktop\\Converter\\ConverterTests\\testFilesText";
            var outputDir = "C:\\Programming\\DocxOdt\\DocxOdt\\desktop\\Converter\\ConverterTests\\outputText";

            convert.ChangeInputDirectory(testFilesDir);
            convert.ChangeOutputDirectory(outputDir);

            convert.DocToOdtMultiple();

            var outputCount = Directory
                .GetFiles(outputDir)
                .Length;

            var testCount = Directory
                .GetFiles(testFilesDir)
                .Length;

            Assert.True(outputCount == testCount);
        }
    }
}
