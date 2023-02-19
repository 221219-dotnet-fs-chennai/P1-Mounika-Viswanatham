const signupbutton = document.querySelector('#submit')
const emailbutton = document.querySelector('#inputEmail4')
const passbutton = document.querySelector('#inputPassword4')
const agebutton = document.querySelector('#age')
const gbutton = document.querySelector('#Gender')
const mobilebutton = document.querySelector('#PhoneNumber')
const namebutton = document.querySelector('#Name')

function addTrainer(name,emailID,password,age,gender,phoneNumber){
    const body = {
        Name: name,
        Password: password,
        EmailID: emailID,
        Age: age,
        Gender: gender,
        PhoneNumber: phoneNumber,
        
    };
    fetch('https://localhost:7128/api/Trainer/AddNewTrainer',{
        method: 'POST',
        body: JSON.stringify(body),
        headers: {
            "content-type": "application/json"
        },
        body:JSON.stringify(item)
    })
    .then(data => data.json())
    .then(response => console.log(response));
}

signupbutton.addEventListener('click',
    
    addTrainer(namebutton,emailbutton,passbutton,agebutton,
        gbutton,webbutton,mobilebutton)
);


/*
const uri='https://localhost:7128/api/Trainer/AddNewTrainer';
function addItem(){
    const addNameTextbox=document.getElementById('Name');

    const item={
        isComplete:false,
        Name:addNameTextbox.value.trim()
    };
    fetch(uri,{
        method:'POST',
        headers:{
            'Accept':'application/json',
            'Content-Type':'application/json'
        },
        body:JSON.stringify(item)
    })
    .then(response=>response.json())
    .then(()=>{
        addNameTextbox.value='';
    })
    .catch(error=>console.error('Unable to additem.',error));
}

*/

// const saveButton=document.querySelector('#submit');
// const n=document.querySelector('#Name');
// function FindByEmailID(EmailID)
// {
//     fetch('https://localhost:7128/api/Trainer/FindTrainerByEmailID?EmailID={EmailID}')
//     .then(Data=>Data.json())
//     .then(response=>displayNotesInForm(response));
// }

// function popularForm(EmailID)
// {
//     FindByEmailID(EmailID);
// }

// function displayNotesInForm(note)
// {
// n.value=note.Name;
// console.log(note.value);
// }