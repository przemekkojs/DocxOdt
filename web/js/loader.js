// Skrypt generujący loading bar

// TODO: Trochę ładniej XD
export class Loader {
    constructor(parent) {
        this.parent = parent;
        this.nothing();
    }

    converted() {
        this.parent.innerText = "Gotowe.";
    }

    converting() {
        this.parent.innerText = "Konwertowanie...";
    }

    nothing() {
        this.parent.innerText = "";
    }
}