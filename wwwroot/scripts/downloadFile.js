//https://stackoverflow.com/questions/32545632/how-can-i-download-a-file-using-window-fetch
function download(url, fileName) {
    console.log(url);
    fetch(url, {
        method: 'GET'
    })
    .then(response => response.blob())
    .then(blob => {
        var url = window.URL.createObjectURL(blob);
        var a = document.createElement('a');
        a.href = url;
        a.download = fileName;
        document.body.appendChild(a);
        a.click();
        a.remove();     
    });
}