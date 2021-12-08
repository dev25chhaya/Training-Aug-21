import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {

  add1="../../assets/angular.png"
  add2="../../assets/add.png"
  link="https://angular.io/"
  constructor() { }

  ngOnInit(): void {
  }

}
