import { Component, OnInit, ChangeDetectorRef, AfterViewInit } from '@angular/core';
import { MediaMatcher } from '@angular/cdk/layout';
import { Subscription } from 'rxjs';

import { AuthenticationService } from '../../core/services/auth.service';
import { SpinnerService } from '../../core/services/spinner.service';
import {TokenData} from '../../core/models/token-data';

@Component({
    selector: 'app-layout',
    templateUrl: './layout.component.html',
    styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit, AfterViewInit {

    private _mobileQueryListener: () => void;
    mobileQuery: MediaQueryList;
    showSpinner: boolean;
    userName: string;
    isAdmin: boolean;
    user: TokenData;

    private autoLogoutSubscription: Subscription;

    constructor(private changeDetectorRef: ChangeDetectorRef,
        private media: MediaMatcher,
        public spinnerService: SpinnerService,
        private authService: AuthenticationService) {

        this.mobileQuery = this.media.matchMedia('(max-width: 1000px)');
        this._mobileQueryListener = () => changeDetectorRef.detectChanges();
        this.mobileQuery.addListener(this._mobileQueryListener);
    }

    ngOnInit(): void {
        this.user = this.authService.getCurrentUser();
        if (this.user){
            this.isAdmin = this.user.isAdmin;
            this.userName = this.user.fullName;
            return;
        }
        this.userName = 'User';
    }

    public logOut() {
        this.authService.logout();
    }

    // ngOnDestroy(): void {
    //     this.mobileQuery.removeListener(this._mobileQueryListener);
    //     this.autoLogoutSubscription.unsubscribe();
    // }

    ngAfterViewInit(): void {
        this.changeDetectorRef.detectChanges();
    }
}
