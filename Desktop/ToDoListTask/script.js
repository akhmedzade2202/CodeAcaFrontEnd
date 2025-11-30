const taskInput = document.getElementById('taskInput');
const addBtn = document.getElementById('addBtn');
const taskList = document.getElementById('taskList');
const completedCount = document.getElementById('completed');
const uncompletedCount = document.getElementById('uncompleted');

let tasks = [];

addBtn.addEventListener('click', function() {
    addTask();
});

taskInput.addEventListener('keypress', function(e) {
    if (e.key === 'Enter') {
        addTask();
    }
});

function addTask() {
    const text = taskInput.value.trim();
    
    if (text !== '') {
        const task = {
            id: Date.now(),
            text: text,
            completed: false
        };
        
        tasks.push(task);
        taskInput.value = '';
        showTasks();
    }
}

function showTasks() {
    taskList.innerHTML = '';
    
    tasks.forEach(function(task) {
        const li = document.createElement('li');
        li.className = 'task-item';
        if (task.completed) {
            li.classList.add('completed');
        }
        
        li.innerHTML = `
            <div class="task-left">
                <input type="checkbox" class="task-checkbox" ${task.completed ? 'checked' : ''}>
                <span class="task-text">${task.text}</span>
            </div>
            <div class="task-buttons">
                <button class="delete-btn">Delete</button>
                <button class="edit-btn">Edit</button>
            </div>
        `;
        
        const checkbox = li.querySelector('.task-checkbox');
        checkbox.addEventListener('click', function() {
            task.completed = !task.completed;
            showTasks();
        });
        
        const deleteBtn = li.querySelector('.delete-btn');
        deleteBtn.addEventListener('click', function() {
            tasks = tasks.filter(function(t) {
                return t.id !== task.id;
            });
            showTasks();
        });
        
        const editBtn = li.querySelector('.edit-btn');
        editBtn.addEventListener('click', function() {
            const newText = prompt('Tapşırığı dəyişdir:', task.text);
            if (newText !== null && newText.trim() !== '') {
                task.text = newText.trim();
                showTasks();
            }
        });
        
        taskList.appendChild(li);
    });
    
    updateCounter();
}

function updateCounter() {
    let completed = 0;
    let uncompleted = 0;
    
    tasks.forEach(function(task) {
        if (task.completed) {
            completed++;
        } else {
            uncompleted++;
        }
    });
    
    completedCount.textContent = completed;
    uncompletedCount.textContent = uncompleted;
}