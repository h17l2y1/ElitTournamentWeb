import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DisqualificationHomeComponent } from './disqualification-home/disqualification-home.component';
import {SharedModule} from '../shared/shared.module';
import {DisqualificationRoutingModule} from './disqualification-routing.module';

@NgModule({
  declarations: [DisqualificationHomeComponent],
  imports: [
    CommonModule,
    SharedModule,
    DisqualificationRoutingModule
  ]
})
export class DisqualificationModule { }
