import * as classes from './assignment'

//store the applicant

let applicant: classes.applicantData[]=[];
function storeApplicant(Id: number, name: string,emailId:string, marks : number, city: string,Degree: string, BirthDate: Date,Experience: number, skills :string[], position: string ){
            applicant.push(new classes.applicantData(Id,name,marks,city,emailId,Degree,BirthDate,Experience,skills,position));
}

// Create Vacancies

let vacancies: classes.vacancies[]=[];
function createVacancies(positions: [number,string], total: number, department: string,JobType: string, maxSal:string, marks: number){
    vacancies.push(new classes.vacancies(positions,total,department,JobType,maxSal,marks));
}

// schedual a interview

let schedule : classes.scheduleInterview[]=[];
function scheduleInterview(date: Date, Interviewer: string, Type: string){
    
    let elegible=applicant.filter(element=>{
        return element.Experience==0 
    })

    schedule.push(new classes.scheduleInterview(date, Interviewer, Type, elegible))
}


// results

let results: classes.results[]=[];

function viewResults( department: string,finalSalary: string, DateofJoining: Date){
    let final=schedule.filter((element)=>{
        return element.Applicants.filter((ele)=>{
            return ele.applicantFullName=="Dev Chhaya"
        })
    })
    
    results.push( new classes.results(final,department,finalSalary,DateofJoining))
}


var choice: number=1;

switch(choice){
    
    // add vacancies and display all vacancies
    
    case 1:
        console.log(`=========================`);
        console.log(`Total vacancies`)
        createVacancies([1,"Jr.Developer"],15,"DotNet","FormOffice","3.5LPA",50);
        createVacancies([2,"Trainee"],30,"DotNet","FormOffice","2.5LPA",50)

        vacancies.forEach(element => {
            element.display();
        });

    case 2:
        console.log(`============================`)
        console.log(`Total Applicants`)
         storeApplicant(1,"Dev Chhaya","absc@gmail.com",80,"Dwarka","B.E.",new Date("2000-06-25"),0,["C,C++,C#,SqlServer"],"Trainee");
         storeApplicant(2,"Ajay Shah","defg@gmail.com",65,"Junagadh","B.E.",new Date("2000-03-21"),5,["NodeJs, ReactJs"],"Hr");

        applicant.forEach(element => {
            element.display();
        });
        

    case 3:
        console.log(`===============================`);
        console.log(`Scheduled applicants`)    
        scheduleInterview(new Date("2021-11-26"),"Sharma Sir","Offline");

        schedule.forEach(element => {
            element.display();
        });



    case 4:
        console.log(`============================`);
        console.log(`Finally selected applicants`);
        viewResults("Node","4LPA",new Date("2021-11-30"));

        results.forEach(element => {
            element.dispaly();
        });

    break;
}
