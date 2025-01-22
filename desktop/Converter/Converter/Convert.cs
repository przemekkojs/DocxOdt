using Aspose.Words;

namespace Converter
{
    public class Convert
    {
        public IO IO { get => _io; }

        private readonly IO _io;

        public const string DOCX = "docx";
        public const string DOC = "doc";
        public const string ODT = "odt";

        public Convert()
        {
            _io = new IO
            {
                InputDirectory = Directory.GetCurrentDirectory(),
                OutputDirectory = Directory.GetCurrentDirectory()
            };
        }

        public static List<string> GetFilesByExtension(string dir, string extenstion)
        {
            var files = Directory
                .GetFiles(dir, $"*.{extenstion}");

            var result = files.ToList();

            return result;
        }

        private List<string> GetFilesByExtension(string extenstion) => GetFilesByExtension(_io.InputDirectory, extenstion);

        private void MultipleConvertTemplate(string from, string to)
        {
            _io.SetDefault();

            var files = GetFilesByExtension(from);

            foreach (var file in files)
            {
                var doc = new Document(file);
                var fileName = Path
                    .GetFileName(file)
                    .Split('.')[0];

                var output = $"{fileName}.{to}";
                var outputPath = Path.Combine(_io.OutputDirectory, output);

                var saveFormat = to switch
                {
                    ODT => SaveFormat.Odt,
                    DOCX => SaveFormat.Docx,
                    DOC => SaveFormat.Doc,
                    _ => throw new ArgumentException("Invalid >to< parameter")
                };

                doc.Save(outputPath, saveFormat);
            }
        }

        public void DocxToOdtMultiple() => MultipleConvertTemplate(DOCX, ODT);
        public void DocToOdtMultiple() => MultipleConvertTemplate(DOC, ODT);
        public void OdtToDocxMultiple() => MultipleConvertTemplate(ODT, DOCX);
        public void OdtToDocMultiple() => MultipleConvertTemplate(ODT, DOC);

        public void ChangeInputDirectory(string inputDirectory) =>
            _io.InputDirectory = inputDirectory;

        public void ChangeOutputDirectory(string outputDirectory) =>
            _io.OutputDirectory = outputDirectory;
    }
}
