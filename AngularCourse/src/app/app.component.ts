import { Component } from '@angular/core';
import { Routes, RouterModule, Router} from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  router: Router;
  constructor(private _router:Router)
  {
    this.router = _router;
  }
  public moveToLogin(){
    this.router.navigate(['./login']);
  }

}
