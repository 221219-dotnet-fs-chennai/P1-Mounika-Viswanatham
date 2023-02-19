//update education details
function handleUpdate() {
    
    let uid = document.getElementById("usid").value
    let inname = document.getElementById("IName").value
    let deg = document.getElementById("degree").value
    let speci = document.getElementById("specialization").value
    let ye = document.getElementById("year").value
    const vre=localStorage.getItem('EmailID');
    let val = vre.split('@');
    User = val[0];
    
    fetch(`https://localhost:7128/api/Education/UpdateEducation?EmailID=${vre}`,{

    
      
      method: "PUT",
  
      
      body: JSON.stringify({
        user_id: User,
        institutionName: inname,
        degree: deg,
        specialization: speci,
        passingYear: ye,
        
      }),
  
     
      headers: {
        "Content-type": "application/json; charset=UTF-8",
      },
    })
    .then((Response) => {
        if(Response.status===200){
            alert("Successfully updated");
            window.location.href='profile.html';
        }
    })
}

//update skill details

function handleUpdateski() {
    
    let uid = document.getElementById("usid").value
    let sk1 = document.getElementById("sk11").value
    let sk2 = document.getElementById("sk12").value
    let sk3 = document.getElementById("sk13").value
    
    const vre=localStorage.getItem('EmailID');
    let val = vre.split('@');
    User = val[0];
    
    fetch(`https://localhost:7128/api/Skill/UpdateTrainer?EmailID=${vre}`,{

    
      
      method: "PUT",
  
      
      body: JSON.stringify({
        user_id: User,
        skill1: sk1,
        skill2: sk2,
        skill3: sk3,
        
        
      }),
  
     
      headers: {
        "Content-type": "application/json; charset=UTF-8",
      },
    })
    .then((Response) => {
        if(Response.status===200){
            alert("Successfully updated");
            window.location.href='profile.html';
        }
    })
}



//update company details

function handleUpdatecom() {
    
   let uid = document.getElementById("usid").value
    let com = document.getElementById("CName").value
    let exp = document.getElementById("Exp").value
 const vre=localStorage.getItem('EmailID');
 let val = vre.split('@');
 User = val[0];
    
    fetch(`https://localhost:7128/api/Company/UpdateCompanyDetails?EmailID=${vre}`,{

     
      method: "PUT",
       body: JSON.stringify({
        user_id: User,
        companyName: com,
        experience: exp,
      }),   
      headers: {
        "Content-type": "application/json; charset=UTF-8",
      },
    })
    .then((Response) => {
        if(Response.status===200){
            alert("Successfully updated");
            window.location.href='profile.html';
        }
    })
}



//update personal details

function handleUpdatePer() {
    
    let uid = document.getElementById("userid").value
     let na = document.getElementById("Name").value
     let email = document.getElementById("inputEmail4").value
     let pas = document.getElementById("inputPassword4").value
     let gen = document.getElementById("Gender").value
     let age1 = document.getElementById("age").value
     let loc = document.getElementById("Locat").value
     let phone = document.getElementById("PhoneNumber").value
     
     const vre=localStorage.getItem('EmailID');
     let val = vre.split('@');
     User = val[0];
     
     fetch(`https://localhost:7128/api/Trainer/UpdateTrainer?Email=${vre}`,{      
       method: "PUT",
        body: JSON.stringify({
         user_id: User,
         name: na,
         gender: gen,
         phoneNumber:phone,
         emailID:email,
         age:age1,
         password:pas,
         location:loc,
       }),   
       headers: {
         "Content-type": "application/json; charset=UTF-8",
       },
    })
     .then((Response) => {
         if(Response.status===200){
             alert("Successfully updated");
             window.location.href='profile.html';
         }
         else{
            alert("Not updated");
         }
     })
 }
 
 
 
 