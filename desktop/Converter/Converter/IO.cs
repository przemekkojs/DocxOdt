namespace Converter
{
    public class IO
    {
        public string InputDirectory { get; set; }
        public string OutputDirectory { get; set; }

        public const string DEFAULT_DIR = "C:/";

        public IO()
        { 
            InputDirectory = string.Empty;
            OutputDirectory = string.Empty;
        }

        public void SetDefault()
        {
            if (!ValidatePaths())
            {
                InputDirectory = DEFAULT_DIR;
                OutputDirectory = DEFAULT_DIR;
            }
        }

        public bool ValidatePaths()
        {
            return
                Directory.Exists(InputDirectory) &&
                Directory.Exists(OutputDirectory);
        }
    }
}
