 
    var Email=document.getElementById("email").value;
    console.log(Email);
            
    fetch(`https://localhost:7128/api/Trainer/FindTrainerByEmailID?EmailID=${Email}`)
    .then(data=>data.json())
    .then(response=>response.forEach(element => {
        const markup=`<li><h5>Trainer By EmailID</h5>
                    Name        : ${element.name}<br>
                    EmailID     : ${element.emailID}<br>
                    Age         : ${element.age}<br>
                    Gender      : ${element.gender}<br>
                    PhoneNumber : ${element.phoneNumber}</li>`
                    

                    document.querySelector('ul').insertAdjacentHTML('beforeend',markup);
        
    }))
    .catch(error=>console.log(error));

               


    
               