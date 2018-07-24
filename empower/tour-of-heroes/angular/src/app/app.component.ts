//import component functionality from angular/core

import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  //specifies main markup file
  templateUrl: './app.component.html',
  //specifies the styles for the component
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angular Tour of Heroes';
}
