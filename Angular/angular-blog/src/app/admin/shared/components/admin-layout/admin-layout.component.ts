import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.services';

@Component({
  selector: 'app-admin-layout',
  templateUrl: './admin-layout.component.html',
  styleUrls: ['./admin-layout.component.scss']
})
export class AdminLayoutComponent implements OnInit {

  constructor(private router: Router,
    public auth: AuthService) { }

  ngOnInit(): void {
  }
  logout(event: Event) {
    // cancel default behavior link
    event.preventDefault();
    this.auth.logout()
    this.router.navigate(['/admin', 'login'])
  }

}
