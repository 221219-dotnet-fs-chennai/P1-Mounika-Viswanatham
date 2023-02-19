function deleteProfile() {
    
        
        document.getElementById("del").addEventListener("click",function(event){
            event.preventDefault();

            var e=document.getElementById('emi').value ;
        console.log(e);
            console.log(e);
            fetch(`https://localhost:7128/api/Trainer/DeleteTrainer?EmailID=${e}`, {
            method:'DELETE',
            headers: {
                'Content-Type': 'application/json',
                'EmailID':e,
            }
        }).then(response=> {
            if(response.status===200) {
                alert("Account Deleted Successfully");
                window.location.replace('login.html');
            }
            else{
                alert("Not deleted");
            }
        })
        .catch(error=>{
            alert("Some Error Occured,Please try after some time...")
        })
        });
}

