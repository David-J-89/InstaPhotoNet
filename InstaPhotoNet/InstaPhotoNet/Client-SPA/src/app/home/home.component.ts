import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode = true;  


  constructor(private http: HttpClient) { }

  ngOnInit() {

  }

  loginToggle() {
    this.registerMode = false;
  }

  registerToggle() {
    this.registerMode = true;
  }

  //cancelRegisterMode(registerMode: boolean) {
  //  this.registerMode = registerMode;
  //} 

}
