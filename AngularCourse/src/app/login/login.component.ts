import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  email:String;
  password:String;
  router:Router;

  constructor( private _router:Router) { 
    this.router= _router;
  }

  ngOnInit() {
  }

  checkEmailAndpassword(){
    if(this.email == "test@test.com" && this.password =="$Test12345")
    {
       alert ("Success");
       this.router.navigate(['./home']);
    }
    else
    {
      alert("Wrong email or password");
    }
  }

}
