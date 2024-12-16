import subprocess

def convert_docx_to_odt(input_file, output_file):
    try:
        subprocess.run(['pandoc', input_file, '-o', output_file], check=True)
        print(f"Conversion successful: {input_file} -> {output_file}")
    except subprocess.CalledProcessError as e:
        print(f"Error during conversion: {e}")

# Example usage:
input_file = "\"C:\\Programming\\DocxOdt\\DocxOdt\\desktop\\ConverterFree\\decyzja wpis warunkowy - niedopuszczenie i niezaliczenie.docx\""  # path to your .docx file
output_file = "C:\\Programming\\DocxOdt\\DocxOdt\\desktop\\ConverterFree\\output.odt"  # desired output .odt file
convert_docx_to_odt(input_file, output_file)
