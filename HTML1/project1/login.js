function login() {
  document.getElementById("sub").addEventListener("click",function(event){
      event.preventDefault();
  
      var email=document.getElementById("Em").value;
      var password=document.getElementById("Pass").value;
     
      fetch(`https://localhost:7128/api/Trainer/Login?EmailID=${email}&Password=${password}`,{
          method:'GET',
          headers:{'Content-Type': 'application/json',    
      'EmailID': email,
      'Password': password
    }
       }).then(response=> {
      if(response.status===200){
        localStorage.setItem('EmailID',email);
        alert("Successfully Logged In");

          window.location.href='profile.html';
        }
       else{
          alert("Login Failed, Please try again");
        }
  })
  });
  }