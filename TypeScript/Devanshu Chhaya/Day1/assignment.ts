// 1.  Store 5 employees’ data in one array (ID,FirstName,LastName,Address,Salary). Do the operation searching by indexnumber, EmployeeID, Insert the employee, 
// delete the employee from the Array. Create one more array emp and join the value with above array. 
// When display list combine firstname and lastname as fullname, From the address field flatnumber,city,state and should be splited.
// PF should be computed and total salary should be display.

var employees:string[][]=[["1","Ajay","Shah","12,Dwarka,Gujarat","15000"],["2","Nilay","Sharma","5,Ahmedabad,Gujarat","20000"]]
// for(var i in employees)
// {
//    for(var j in employees[i]){
//         console.log(employees[i][j])
//    }
// }


//insert a new employee


var newemp = employees.push(["3","Milan","Varma","1,Dilhi,NCR","25000"],["4","Dinesh","Sharma","2,Mumbai,Maharashtra","120000"],["5","Rakesh","Singh","52,Rajkot,Gujarat","50000"])

// for(var i in employees){
//     for( var j in employees[i]){
//         console.log(employees[i][j])
//     }
// }


// remove one employee

var rmoveemp = employees.pop();

// for(var i in employees){
//     for( var j in employees[i]){
//         console.log(employees[i][j])
//     }
// }

// merge two employee

var secondEmp:string[][]=[["6","Dev","Chhaya","1,Junagadh,Gujarat","60000"]] 

var totalEmp:string[][]=[...employees,...secondEmp]

//  for(var i in totalEmp){
//      for( var j in totalEmp[i]){
//          console.log(totalEmp[i][j])
//      }
//  }


// find employee by id

var empid= "4"

for(var j in totalEmp){
    if(empid==totalEmp[j][0]){
        for(var i in totalEmp[j]){
            console.log(totalEmp[j][i])
        }
    }
}

// display the employee details

for(var i in totalEmp){
    console.log("EmployeeId: "+totalEmp[i][0]);
    console.log("FullName :"+totalEmp[i][1]+" "+totalEmp[i][2]);
    console.log("Address:"+totalEmp[i][3].split(","));
    console.log("Salary: "+totalEmp[i][4]);
    console.log("PF: "+parseInt(totalEmp[i][4])*0.8);
}





