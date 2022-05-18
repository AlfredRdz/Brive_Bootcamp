/*function myFunc(theObject) {
    theObject.make = "Toyota";
}

var x, y;

var myCar = {make: 'Honda', model: 'Accord', year: 1998}

x = myCar.make;

console.log("El valor de x ", x);

myFunc(myCar);

y = myCar.make;

console.log("El valor de y ", y);
*/

// ejercicio 2

/*
const square = function (number) {
    return number * number;
}

const square2 = number =>  number * number;

let a = square(4);
let b = square2(8);

console.log("El resultado de a ", a);
console.log("El resultado de b ", b);
*/

// ejercicio 3

const tasks = [
    {
        'name': 'Write for envato tust+',
        'duration': 120
    },
    {
        'name': 'Work out',
        'duration': 60
    },
    {
        'name': 'Procastinate on dualingo',
        'duration': 240
    }
]

const task_name = [];

/*
for (let i = 0; i < tasks.length; i++) {
    task_name.push(tasks[i].name);   
}
*/

/*
tasks.forEach(function (task) {
    task_name.push(task.name)
})
*/

const task_name3 = tasks.map(function (task, index, array) {
    return task.name;
})

console.log(task_name3);