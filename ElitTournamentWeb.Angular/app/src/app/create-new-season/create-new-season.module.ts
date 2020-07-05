import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {CreateNewSeasonHomeComponent} from './create-new-season-home/create-new-season-home.component';
import {SharedModule} from '../shared/shared.module';
import {CreateNewSeasonRoutingModule} from './create-new-season.routing.module';

@NgModule({
    declarations: [CreateNewSeasonHomeComponent],
    imports: [
        CommonModule,
        SharedModule,
        CreateNewSeasonRoutingModule
    ]
})
export class CreateNewSeasonModule {
}
