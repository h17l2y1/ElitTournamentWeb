import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';
import {FormControl, Validators, FormGroup} from '@angular/forms';
import {Title} from '@angular/platform-browser';
import 'rxjs/add/operator/delay';

import {AuthenticationService} from '../../core/services/auth.service';
import {NotificationService} from '../../core/services/notification.service';
import {LogInRequest} from '../../core/models/log-in-request';
import { JwtResponse } from 'src/app/core/models/jwt-response';

const TOKEN_DATA_KEY: string = "TOKEN_DATA_KEY";

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

    loginForm: FormGroup;
    loginModel: LogInRequest;
    jwt: JwtResponse;
    loading: boolean;

    constructor(private router: Router, private titleService: Title, private notificationService: NotificationService,
                private authenticationService: AuthenticationService) {
    }

    ngOnInit() {
        this.titleService.setTitle('Элит Турнир - Login');
        // this.authenticationService.logout();
        this.createForm();
    }

    private createForm() {
        const savedUserEmail = localStorage.getItem('savedUserEmail');

        this.loginForm = new FormGroup({
            email: new FormControl(savedUserEmail, [Validators.required, Validators.email]),
            password: new FormControl('', Validators.required),
            rememberMe: new FormControl(savedUserEmail !== null)
        });
    }

    login() {
        this.loginModel = new LogInRequest()
        this.loginModel.login = this.loginForm.get('email').value;
        this.loginModel.password = this.loginForm.get('password').value;

        this.loading = true;
        this.authenticationService.login(this.loginModel).subscribe(response => {
            if (response){
                this.jwt = response;
                localStorage.setItem(TOKEN_DATA_KEY, JSON.stringify(this.jwt));
                this.router.navigate(['/']);
            }
            },
            error => {
                this.notificationService.openSnackBar(error.error);
                this.loading = false;
            }
        );
    }

    resetPassword() {
        this.router.navigate(['/auth/password-reset-request']);
    }
}
