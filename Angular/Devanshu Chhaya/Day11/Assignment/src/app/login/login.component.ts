import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  message: string;

  constructor(public authService: AuthService, private router: Router) {
    this.message = '';
  }

  login(username: string, password: string): boolean {
    this.message = '';
    if (!this.authService.login(username, password)) {
      this.message = 'Incorrect credentials.';
      // setTimeout(function() {
      //   this.message = '';
      // }.bind(this), 2500);
    }
    else{
      this.authService.login(username, password);
      this.router.navigate(['/html']);
    }
    return false;

  }

  logout(): boolean {
    this.authService.logout();
    return false;
  }

  ngOnInit(): void {
  }

}
