import os
import glob

input_dir:str = os.getcwd()
output_dir:str = os.getcwd()
input_file:str

def get_files_by_ext(ext:str) -> list[str]:
    file_names = [os.path.basename(f) for f in glob.glob(f"{input_dir}/*.{ext}") if os.path.isfile(f)]
    return file_names
