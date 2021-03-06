import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainHomeComponent } from './main-home/main-home.component';
import {SharedModule} from '../shared/shared.module';
import { MainRoutingModule } from './main-routing.module';
import {MatInputModule} from '@angular/material';

@NgModule({
  declarations: [MainHomeComponent],
    imports: [
        CommonModule,
        SharedModule,
        MainRoutingModule,
        MatInputModule
    ]
})
export class MainModule { }
