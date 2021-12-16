import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  currentItem="IPad"

  items=["IPhone","IMac"]

  addItem(newItem: string){
    this.items.push(newItem);
  }
}
