function viewded(){
    const btn = document.getElementById("vid")
        btn.addEventListener("submit", (e) =>{
          e.preventDefault()
          
        })
    const vre= localStorage.getItem('EmailID');
    //fetch(`https://localhost:7128/api/Trainer/GetTrainer/${vre}`)
    //fetch(`https://localhost:7128/api/Trainer/GetTrainer/${vre}`)
    fetch(`https://localhost:7128/api/Education/GetEducationById/${vre}`)
        .then(data=>{return data.json();})
        .then(response=>{
            response.forEach(user =>{
                const markup=`<li><h3>Personal details</h3>
                    InstitutionName    :${user.institutionName} <br>
                    Degree             :${user.degree} <br>
                    Specialization     :${user.specialization}<br>
                    PassingYear     :${user.passingYear}<br>
                   
                   
                    </li>`;
                
                document.querySelector('ul').insertAdjacentHTML('beforeend',markup);
            })
        })

 }


 function viewskill(){
    const vre= localStorage.getItem('EmailID');
    fetch(`https://localhost:7128/api/Skill/GetSkillById/${vre}`)
   
        .then(data=>{return data.json();})
        .then(response=>{
            response.forEach(user =>{
                const markup=`<li><h3>Skills details</h3>
                    skill1     :${user.skill1} <br>
                    skill2     :${user.skill2} <br>
                    skill3     :${user.skill3}<br>
                    
                    </li>`;
                
                document.querySelector('ol').insertAdjacentHTML('beforeend',markup);
            })
        })

 }
    

 function viewde(){
    const vre= localStorage.getItem('EmailID');
    fetch(`https://localhost:7128/api/Trainer/GetTrainer/${vre}`)
   
        .then(data=>{return data.json();})
        .then(response=>{
            response.forEach(user =>{
                const markup=`<li><h3>Personal details</h3>
                    Name        :${user.name} <br>
                    EmailId     :${user.emailID} <br>
                    Age         :${user.age}<br>
                    Gender      :${user.gender}<br>
                    Location    :${user.location}<br>
                    PhoneNumber :${user.phoneNumber}<br>
                    skill1     :${user.skill1} <br>
                    skill2     :${user.skill2} <br>
                    skill3     :${user.skill3}<br>
                    InstitutionName    :${user.institutionName} <br>
                    Degree             :${user.degree} <br>
                    Specialization     :${user.specialization}<br>
                    PassingYear     :${user.passingYear}<br>
                   
                    </li>`;
                
                document.querySelector('ul').insertAdjacentHTML('beforeend',markup);
            })
        })

}