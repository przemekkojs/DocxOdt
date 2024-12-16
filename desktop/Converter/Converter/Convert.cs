using Aspose.Words;

namespace Converter
{
    public class Convert
    {
        private readonly IO _io;

        private const string DOCX = "docx";
        private const string DOC = "doc";
        private const string ODT = "odt";

        public Convert()
        {
            _io = new IO
            {
                InputDirectory = Directory.GetCurrentDirectory(),
                OutputDirectory = Directory.GetCurrentDirectory()
            };
        }

        private List<string> GetFilesByExtension(string extenstion)
        {
            var files = Directory
                .GetFiles(_io.InputDirectory, $"*.{extenstion}");

            var result = files.ToList();

            return result;
        }

        private void ConvertTemplate(string from, string to)
        {
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

        public void DocxToOdt() => ConvertTemplate(DOCX, ODT);
        public void DocToOdt() => ConvertTemplate(DOC, ODT);
        public void OdtToDocx() => ConvertTemplate(ODT, DOCX);
        public void OdtToDoc() => ConvertTemplate(ODT, DOC);

        public void ChangeInputDirectory(string inputDirectory) =>
            _io.InputDirectory = inputDirectory;

        public void ChangeOutputDirectory(string outputDirectory) =>
            _io.OutputDirectory = outputDirectory;
    }
}
