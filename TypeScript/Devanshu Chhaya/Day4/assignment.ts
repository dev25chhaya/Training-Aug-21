// Store 5 Employee Data(ID,Name,City,DOJ) in one Array. Search the employee with ID.

// Search the employees who has joined after year 2020

// Search the employee who has joined after year 2020 and stays in Mumbai city


// array of the employee

let employee: {empid: number, empname: string, empCity: string, DateOj: Date}[]=[
    {"empid":1, "empname":"Ajay", "empCity":"Dwarka","DateOj":new Date("2021-06-26")},
    {"empid":2, "empname":"Milan", "empCity":"Junagadh","DateOj":new Date("2020-06-26")},
    {"empid":3, "empname":"Dinesh", "empCity":"Mumbai","DateOj":new Date("2021-06-26")},
    {"empid":4, "empname":"Nilay", "empCity":"Ahmedabad","DateOj":new Date("2021-06-26")},
    {"empid":5, "empname":"Mehul", "empCity":"Mumbai","DateOj":new Date("2019-06-26")}
];

// employee joined after 2020

let after2020 = employee.filter(elemetns=>{
    return elemetns.DateOj.getFullYear()>2020;
})

after2020.forEach(element => {
    console.log(`Id: ${element.empid} || Name: ${element.empname} || City: ${element.empCity} || DateofJoining: ${element.DateOj}`);
});

// employee joined after 2020 and from mumbai

let emp2020fromMum = employee.filter(elemetns=>{
    return elemetns.DateOj.getFullYear()>2020 && elemetns.empCity=="Mumbai";
})

emp2020fromMum.forEach(element => {
    console.log(`Id: ${element.empid} || Name: ${element.empname} || City: ${element.empCity} || DateofJoining: ${element.DateOj}`);
});