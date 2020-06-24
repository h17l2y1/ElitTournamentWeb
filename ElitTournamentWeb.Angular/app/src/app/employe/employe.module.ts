import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeHomeComponent } from './employe-home/employe-home.component';
import {SharedModule} from '../shared/shared.module';
import { EmployeRoutingModule } from './employe-routing.module';

@NgModule({
  declarations: [EmployeHomeComponent],
  imports: [
    CommonModule,
    SharedModule,
    EmployeRoutingModule
  ]
})
export class EmployeModule { }
