import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ScheduleHomeComponent } from './schedule-home/schedule-home.component';
import {ScheduleRoutingModule} from './schedule-routing.module';
import {SharedModule} from '../shared/shared.module';

@NgModule({
  declarations: [
      ScheduleHomeComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    ScheduleRoutingModule
  ]
})
export class ScheduleModule { }
