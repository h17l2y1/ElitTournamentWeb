import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './core/guards/auth.guard';

const appRoutes: Routes = [
    {
        path: 'auth',
        loadChildren: './auth/auth.module#AuthModule'
    },
    {
        path: 'main',
        loadChildren: './main/main.module#MainModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'dashboard',
        loadChildren: './dashboard/dashboard.module#DashboardModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'schedule',
        loadChildren: './schedule/schedule.module#ScheduleModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'result',
        loadChildren: './result/result.module#ResultModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'statistic',
        loadChildren: './statistic/statistic.module#StatisticModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'disqualification',
        loadChildren: './disqualification/disqualification.module#DisqualificationModule',
        canActivate: [AuthGuard]
    },
    // {
    //     path: 'employe',
    //     loadChildren: './employe/employe.module#EmployeModule',
    //     canActivate: [AuthGuard]
    // },
    {
        path: 'employe',
        loadChildren: './employe/employe.module#EmployeModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'account',
        loadChildren: './account/account.module#AccountModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'about',
        loadChildren: './about/about.module#AboutModule',
        canActivate: [AuthGuard]
    },
    {
        path: '**',
        redirectTo: 'dashboard',
        pathMatch: 'full'
    }
];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule],
    providers: []
})
export class AppRoutingModule { }
