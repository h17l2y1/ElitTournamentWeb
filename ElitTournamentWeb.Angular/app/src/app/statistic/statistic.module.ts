import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StatisticHomeComponent } from './statistic-home/statistic-home.component';
import {SharedModule} from '../shared/shared.module';
import { StatisticRoutingModule } from './statistic-routing.modile';

@NgModule({
  declarations: [StatisticHomeComponent],
  imports: [
    CommonModule,
    SharedModule,
    StatisticRoutingModule
  ]
})

export class StatisticModule { }
