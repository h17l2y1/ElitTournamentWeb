import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {SharedModule} from '../shared/shared.module';
import {ResultRoutingModule} from './result-routing.module';
import { ResultHomeComponent } from './result-home/result-home.component';

@NgModule({
  declarations: [
    ResultHomeComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    ResultRoutingModule
  ]
})
export class ResultModule { }
