import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  form: FormGroup

  ngOnInit(): void {
    this.form = new FormGroup({
      email: new FormControl('', [Validators.email, Validators.required]),
      password: new FormControl(null, [Validators.required, Validators.minLength(6)]),
      address: new FormGroup({
        country: new FormControl('ua'),
        city: new FormControl('Kyiv', Validators.required)
      })
    })
  }
  submit() {
    console.log('Form:', this.form)
    const formData = { ...this.form.value }
    console.log('Form value: ', formData)
  }

  SetCapital() {
    const cityMap: any = {
      ua: 'Ukraine',
      pl: 'Poland',
      us: 'USA'
    }

    const cityKey = this.form.get('address')?.get('country')?.value
    const city = cityMap[cityKey]

    this.form.patchValue({
      address: { city: city }
    })
  }
}
