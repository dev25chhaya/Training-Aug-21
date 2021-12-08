import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello-worlds',
  templateUrl: './hello-worlds.component.html',
  styleUrls: ['./hello-worlds.component.css']
})
export class HelloWorldsComponent implements OnInit {

  myname="Devanshu";
  greetings="Hello"

  constructor() { }

  ngOnInit(): void {
  }

}
