import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';
import {FormBuilder, FormGroup, Validators} from '@angular/forms'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  form: FormGroup;
  formData = new FormData();

  constructor(
    private fb: FormBuilder,
    private http: AuthService,
    private router: Router){ }
  
    ngOnInit() {
    this.form = this.fb.group({
      email: ['', Validators.required],
      password: ['', Validators.required]
    })
  }
  
    login(){
      this.http.login(this.form.value).subscribe(resp =>{
        console.log(resp);
      })
    }

    

    





}
