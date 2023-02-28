function signup() 
{
    const user=document.getElementById('userid');
    const nam=document.getElementById('Name');
    const email=document.getElementById('inputEmail4');
    const pad=document.getElementById('inputPassword4');
    const gen=document.getElementById('Gender');
    const age=document.getElementById('age');
    const pho=document.getElementById('phoneNumber');
    const loc=document.getElementById('Location');
    
    form.addEventListener('click', event=> {
        event.preventDefault();});

        const formData = new FormData(form);

        const data=Object.fromEntries(formData);
        console.log(data);
        const d={
            'user_id':'user',
            'name':'nam',
            'gender':'gen',
            'emailID':'email',
            'age':'age',
            'password':'pas',
            'location':'loc',
        }

        fetch('https://localhost:7128/api/Trainer/AddNewTrainer', {
        method:'POST',
        body:JSON.stringify(d),
        headers: {
            'Content-Type': 'application/json',
          },
       
        }).then(response=> {
        if(response.status===200) {
            
            alert("Successfully Registered");
            window.location.href('login.html');
        }
        else{
           alert("not entered");
        }
    })
    .catch(error=>{
        alert("Some Error Occured,Please try after some time...")
    });
    
}