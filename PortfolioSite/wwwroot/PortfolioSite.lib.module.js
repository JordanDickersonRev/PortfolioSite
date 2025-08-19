export function beforeWebStart(options) {
    let div = document.createElement("div");
    div.id = 'loadingIndicator';
    document.body.appendChild(div);
}