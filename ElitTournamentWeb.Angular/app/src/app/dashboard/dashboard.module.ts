import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {DashboardRoutingModule} from './dashboard-routing.module';
import {SharedModule} from '../shared/shared.module';
import {DashboardHomeComponent} from './dashboard-home/dashboard-home.component';

@NgModule({
    imports: [
        CommonModule,
        DashboardRoutingModule,
        SharedModule
    ],
    declarations: [
        DashboardHomeComponent
    ],
    entryComponents: []
})
export class DashboardModule {
}
