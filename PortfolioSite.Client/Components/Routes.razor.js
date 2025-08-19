export function afterWebAssemblyStarted(blazor) {
    let progress = document.getElementById('loadingIndicator');
    progress.remove();
}