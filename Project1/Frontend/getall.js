   function getAllNotes(){
    fetch('https://localhost:7128/api/Trainer/GetAllTrainerData')
    .then(data=>{return data.json();})
    .then(response=>{
        response.forEach(user =>{
            const markup=`<td>${user.name}</td><td>${user.emailID}</td><td>${user.age}</td><td>${user.gender}</td><td>${user.location}</td><td>${user.phoneNumber}</td><td>${user.skill1}</td><td>${user.skill2}</td><td>${user.skill3}</td>`;
            
            document.querySelector('table').insertAdjacentHTML('beforeend',markup);
        })
    })
    .catch(error => console.log(error));
    }
    getAllNotes();


   
