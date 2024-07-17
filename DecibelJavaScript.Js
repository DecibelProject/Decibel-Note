let projectDirectoryHandle = null;
let currentFileType = '';
let currentFileName = '';

document.getElementById('createProjectBtn').addEventListener('click', () => {
    document.getElementById('projectModal').style.display = 'block';
});

document.getElementById('closeProjectModal').addEventListener('click', () => {
    document.getElementById('projectModal').style.display = 'none';
});

document.getElementById('createProject').addEventListener('click', async () => {
    const projectName = document.getElementById('projectName').value;
    if (projectName) {
        try {
            if ('showDirectoryPicker' in window) {
                // Открываем диалог для выбора директории
                const rootHandle = await window.showDirectoryPicker();
                // Создаем новую директорию с именем проекта
                projectDirectoryHandle = await rootHandle.getDirectoryHandle(projectName, { create: true });
                document.getElementById('projectModal').style.display = 'none';
                document.getElementById('fileTypeModal').style.display = 'block';
                document.getElementById('addFileBtn').style.display = 'inline-block'; // Показываем кнопку "Добавить файл"
            } else {
                alert('Фатальная ошибка File System Access Api.');
            }
        } catch (error) {
            alert('Ошибка при выборе директории: ' + error);
        }
    } else {
        alert('Введите имя проекта');
    }
});

document.getElementById('addFileBtn').addEventListener('click', () => {
    document.getElementById('fileTypeModal').style.display = 'block';
});

document.getElementById('openProjectBtn').addEventListener('click', async () => {
    try {
        if ('showDirectoryPicker' in window) {
            // Открываем диалог для выбора директории
            projectDirectoryHandle = await window.showDirectoryPicker();
            // Отображаем файлы в выбранной директории
            displayFiles();
            document.getElementById('fileListContainer').style.display = 'block';
        } else {
            alert('Ваш браузер не поддерживает File System Access API');
        }
    } catch (error) {
        alert('Ошибка при выборе директории: ' + error);
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
        document.getElementById('editor').value = ''; // Очистка редактора
    } else {
        alert('Введите имя файла');
    }
});

document.getElementById('closeEditorModal').addEventListener('click', () => {
    document.getElementById('editorModal').style.display = 'none';
});

document.getElementById('saveContent').addEventListener('click', async () => {
    const content = document.getElementById('editor').value;
    if (projectDirectoryHandle && currentFileName && content) {
        try {
            // Создаем новый файл или открываем существующий
            const fileHandle = await projectDirectoryHandle.getFileHandle(currentFileName, { create: true });
            const writable = await fileHandle.createWritable();
            await writable.write(content);
            await writable.close();
    document.getElementById('customAlert').style.display = 'block';
            // Обновляем список файлов после сохранения
            displayFiles();
        } catch (error) {
            alert('Ошибка при сохранении файла: ' + error);
        }
    } else {
        alert('Ошибка при сохранении файла');
    }
});

// Функция для отображения файлов в текущей директории проекта
async function displayFiles() {
    const fileList = document.getElementById('fileList');
    fileList.innerHTML = ''; // Очистка текущего списка

    for await (const entry of projectDirectoryHandle.values()) {
        if (entry.kind === 'file') {
            const listItem = document.createElement('li');
            listItem.textContent = entry.name;

            const editButton = document.createElement('button');
            editButton.textContent = 'Редактировать';
            editButton.addEventListener('click', () => openFileForEditing(entry));

            listItem.appendChild(editButton);
            fileList.appendChild(listItem);
        }
    }
}

// Функция для открытия файла на редактирование
async function openFileForEditing(fileHandle) {
    try {
        const file = await fileHandle.getFile();
        const content = await file.text();

        currentFileName = fileHandle.name;
        document.getElementById('editor').value = content;
        document.getElementById('editorModal').style.display = 'block';
    } catch (error) {
        alert('Ошибка при открытии файла: ' + error);
    }
}
document.getElementById('okButton').addEventListener('click', function() {
    document.getElementById('customAlert').style.display = 'none';
});
