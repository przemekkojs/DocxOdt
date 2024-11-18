// Skrypt z podpinaniem logiki do elementów html
import { Loader } from "./loader.js"
import { convertDocxToOdt } from "./converter.js"

class Downloader {
    constructor(parent) {
        this.parent = parent;
        this.container = document.createElement('div');
        this.container.id = "downloader";
        this.container.className = "block child";

        this.label = document.createElement('label');
        this.label.for = "file-download";
        this.label.className = "label";

        this.image = document.createElement('img');
        this.image.src = "img/docxIcon.png"; // TODO: Change to odtIcon.png
        this.image.alt = "Pobierz plik";
        this.image.title = "Pobierz plik";
        this.image.className = "image";

        this.input = document.createElement('input');
        this.input.type = "button";
        this.input.id = "file-download";
        this.input.className = "input";

        this.fileInfo = document.createElement('div');
        this.fileInfo.id = 'download-info';
        this.fileInfo.className = "file-info";

        this.label.appendChild(this.image);
        this.container.appendChild(this.label);
        this.container.appendChild(this.input);
        this.container.appendChild(this.fileInfo);

        this.link = document.createElement('a');

        this.enabled = false;
    }

    enable() {
        if (!this.enabled) {
            this.parent.appendChild(this.container);
            this.enabled = true;
        }        
    }

    disable() {
        if (this.enabled) {
            this.parent.removeChild(this.container);
            this.enabled = false;
            this.setFileInfo("");
        }
    }

    setFileInfo(file) {
        if (file === "") {
            this.fileInfo.innerHTML = '<span class="err">Błąd konwersji pliku.</span>';
        }
        else if(this.enabled) {
            this.fileInfo.innerHTML =  `
                <b>Nazwa pliku: </b> ${file.name}<br/>
                <b>Rozmiar: </b> ${file.size} bajtów
            `;
        }        
    }

    setDownload(blob, docxFile) {
        this.input.removeEventListener('click', () => this.link.click);

        this.link.href = URL.createObjectURL(blob);
        this.link.download = docxFile.name.replace('.docx', '.odt');
        
        this.input.addEventListener('click', () => this.link.click);
    }
}

const fileInput = document.getElementById('file-upload');
const uploadInfo = document.getElementById('upload-info'); 
const fileNotSelected = "Nie wybrano pliku.";
const downloader = new Downloader(document.getElementById('main'));
const loader = new Loader(document.getElementById('loader'));

uploadInfo.innerText = fileNotSelected;

function fileSelected(file) {
    return `
        <b>Nazwa pliku: </b> ${file.name}<br/>
        <b>Rozmiar: </b> ${file.size} bajtów
    `;
}

fileInput.addEventListener('change', async (event) => {
    downloader.disable();
    const docxFile = event.target.files[0];

    if (docxFile) {
        uploadInfo.innerHTML = fileSelected(docxFile);
        
        const reader = new FileReader();
        reader.onload = function(e) {
            loader.converting();
        };
        
        reader.onerror = function(e) {
            // TODO: Jakiś ładniejszy komunikat
        };
        
        reader.readAsText(docxFile);

        const docxContent = await docxFile.arrayBuffer();
        const odtContent = convertDocxToOdt(docxContent);

        const blob = new Blob([odtContent], { type: 'application/vnd.oasis.opendocument.text' });

        downloader.enable();
        downloader.setDownload(blob, docxFile);

        downloader.setFileInfo(""); // TODO: Ustawić na info o pliku
        loader.converted();
    }
    else {
        uploadInfo.innerHTML = fileNotSelected;
        downloader.disable();
        loader.nothing();
    }
});