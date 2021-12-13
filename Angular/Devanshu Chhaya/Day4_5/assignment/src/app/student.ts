// export interface IStuName{
//     firstName:string;
//     middleName:string;
//     lastName:string;
// }

export interface IStudent{
    Name:{
        firstName:string;
        middleName:string;
        lastName:string;
    };
    birthInfo:{
        dob:Date;
        placeofbirth:string;
        firstLanguage:string;
    };
    address:{
        city:string;
        state:string;
        country:string;
        pin:number;
    };
    father:{
        firstName:string;
        middleName:string;
        lastName:string;
        email:string;
        educationalQualification:string;
        profession:string;
        designation:string;
        phoneNumber:number
    };
    mother:{
        firstName:string;
        middleName:string;
        lastName:string;
        email:string;
        educationalQualification:string;
        profession:string;
        designation:string;
        phoneNumber:number
    };
    emergencyContectList:[{
        relation:string;
        phoneNumber:number;
    }];
    referenceThrough:string;
    add:string;
    
}