import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  inputValue = ''

  onInput(event: any) {
this.inputValue = (<HTMLInputElement>event.target).value
  }

  onBlur(str: string){
    this.inputValue = str
  }

  onClick(){
    console.log('Click!')
  }
}
