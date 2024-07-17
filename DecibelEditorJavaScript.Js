let projectName = '';
let currentFileType = '';
let currentFileName = '';

document.getElementById('createProjectBtn').addEventListener('click', () => {
    document.getElementById('projectModal').style.display = 'block';
});

document.getElementById('closeProjectModal').addEventListener('click', () => {
    document.getElementById('projectModal').style.display = 'none';
});

document.getElementById('createProject').addEventListener('click', () => {
    projectName = document.getElementById('projectName').value;
    if (projectName) {
        document.getElementById('projectModal').style.display = 'none';
        document.getElementById('fileTypeModal').style.display = 'block';
    } else {
        alert('??????? ??? ???????');
    }
});

document.getElementById('closeFileTypeModal').addEventListener('click', () => {
    document.getElementById('fileTypeModal').style.display = 'none';
});

document.getElementById('selectFileType').addEventListener('click', () => {
    currentFileType = document.getElementById('fileType').value;
    document.getElementById('fileTypeModal').style.display = 'none';
    document.getElementById('fileNameModal').style.display = 'block';
});

document.getElementById('closeFileNameModal').addEventListener('click', () => {
    document.getElementById('fileNameModal').style.display = 'none';
});

document.getElementById('saveFile').addEventListener('click', () => {
    const fileName = document.getElementById('fileName').value;
    if (fileName) {
        currentFileName = fileName + currentFileType;
        document.getElementById('fileNameModal').style.display = 'none';
        document.getElementById('editorModal').style.display = 'block';
        document.getElementById('editor').value = ''; // ??????? ?????????
    } else {
        alert('??????? ??? ?????');
    }
});

document.getElementById('closeEditorModal').addEventListener('click', () => {
    document.getElementById('editorModal').style.display = 'none';
});

document.getElementById('saveContent').addEventListener('click', () => {
    const content = document.getElementById('editor').value;
    if (projectName && currentFileName && content) {
        // ??????? ?????????? ?????
        const blob = new Blob([content], { type: 'text/plain' });
        const url = URL.createObjectURL(blob);

        // ??????? ?????? ??? ?????????? ?????
        const a = document.createElement('a');
        a.href = url;
        a.download = `${projectName}/${currentFileName}`;
        document.body.appendChild(a);
        a.click();

        // ??????? ?????? ????? ?????????? ?????
        document.body.removeChild(a);
        URL.revokeObjectURL(url);

        alert('???? ????????');
    } else {
        alert('?????? ??? ?????????? ?????');
    }
});
