// This project is aimed at developing a web-based and central Recruitment Process System for the HR Group for a company. 
// Some features of this system will be creating vacancies, storing Applicants data, Interview process initiation, Scheduling Interviews,
//  Storing Interview results for the applicant and finally Hiring of the applicant. Reports may be required to be generated for 
//  the use of HR group.

export class applicantData {
    applicantId: number;
    applicantFullName: string;
    emailId: string;
    Marks: number;
    City: string;
    Degree: string;
    BirthDate: Date;
    Experience: number;
    Skills: string[];
    position: string;
    
    constructor(id: number,name: string, marks:number, city: string,email: string, degree: string, bdate: Date, year: number, skills: string[],position: string){
        this.applicantId=id;
        this.applicantFullName=name;
        this.Marks=marks;
        this.City=city;
        this.emailId= email;
        this.Degree= degree;
        this.BirthDate=bdate;
        this.Experience=year;
        this.Skills=skills;
        this.position=position;        
    }

    display():void{
        console.log(`ID: ${this.applicantId} || Name: ${this.applicantFullName} || Marks: ${this.Marks} || City: ${this.City} || emailId:${this.emailId}`);
        console.log(`Degree: ${this.Degree} || Birthdate: ${this.BirthDate} || Experience: ${this.Experience}`);
    }
}

export class vacancies {
    numberOfvacncies: number;
    department: string;
    positions: [number,string];
    JobType: string;
    MaxSalary: string;
    cutoffMarks: number;
    
    constructor(positions: [number,string], vacancies: number, dep: string,jobType: string, maxSalary:string,cutoff: number ){
        this.numberOfvacncies= vacancies;
        this.department= dep;
        this.positions=positions;
        this.JobType=jobType;
        this.MaxSalary=maxSalary;
        this.cutoffMarks=cutoff;        
    }

    display():void{
        console.log(`Position: ${this.positions[1]} || Total Vacancies: ${this.numberOfvacncies} || Department: ${this.department} || JobType: ${this.JobType} || MaxSalary: ${this.MaxSalary}`);
    }
}

export class scheduleInterview{
    InterviewDate: Date;
    Interviewer: string;
    Type: string;
    Applicants: applicantData[];
    
    constructor(Dateofinterview:Date,Interviewer: string, Type: string, Applicants: applicantData[]){
        this.InterviewDate=Dateofinterview;
        this.Interviewer=Interviewer;
        this.Type= Type;
        this.Applicants= Applicants;
    }

    display(): void{
        console.log(`InerviewDate: ${this.InterviewDate} || Interviewer: ${this.Interviewer} || Type: ${this.Type} `);
        this.Applicants.forEach(element => {
            console.log(`ApplicantId: ${element.applicantId} || AppicantName: ${element.applicantFullName} || ${element.emailId}`)
        });
    }
}

export class results {
    FinalApplicants: scheduleInterview[];
    department: string;
    finalSlary: string;
    DateofJoining: Date;
    
    constructor(applicants : scheduleInterview[], department: string, finalSalary: string, DateofJoining: Date) {
        this.FinalApplicants= applicants;
        this.department= department;
        this.finalSlary= finalSalary;
        this.DateofJoining= DateofJoining;
    }

    dispaly():void{
        
        this.FinalApplicants.forEach(element=>{
            element.Applicants.forEach(ele=>{
                console.log(`Name: ${ele.applicantFullName} || Email: ${ele.emailId}`);
            })
        })

        console.log(`Department: ${this.department} || FinalSalary: ${this.finalSlary} || DateOfJoining: ${this.DateofJoining}`)
    }
}



