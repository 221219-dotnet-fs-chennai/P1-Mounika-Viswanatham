// const uri='https://localhost:7128/api/Trainer/DeleteTrainer?EmailID={EmailID}';
// const email=document.getElementById('Email');
// function deleteItem(EmailID){
//     fetch(`${uri}/${email}`,{
//         method:'Delete',
//         headers:{
//             "content-type":"application/json",
//             'EmailID':emaail
//         }
//     })
//     .then(response=>{
//         if(response.status===200){
//             alert("Deleted");
//             window.location.replace("starting.html");
//         }
//     })
//     .catch(error=>{
//         alert("Error occured");
//     })
    
// }

// function deleteProfile() {
    
//         const email=document.getElementById('Email');
//             console.log(email);
//             fetch('https://localhost:7128/api/Trainer/DeleteTrainer', {
//             method:'DELETE',
//             headers: {
//                 'Content-Type': 'application/json',
//                 'EmailID':email,
//             }
//         }).then(response=> {
//             if(response.status===200) {
//                 alert("Account Deleted Successfully");
//                 window.location.replace('LoginPage.html');
//             }
//             else{
//                 alert("Not deleted");
//             }
//         })
//         .catch(error=>{
//             alert("Some Error Occured,Please try after some time...")
//         });
    
// }

// deleteProfile();