import { Component, OnInit } from '@angular/core';
import {AuthenticationService} from '../../core/services/auth.service';
import {TokenData} from '../../core/models/token-data';
import {ScheduleItem} from '../../core/models/schedule/schedule-item';

@Component({
  selector: 'app-schedule-home',
  templateUrl: './schedule-home.component.html',
  styleUrls: ['./schedule-home.component.css']
})
export class ScheduleHomeComponent implements OnInit {

  public user: TokenData;
  public editMode: boolean;

  constructor(private authService: AuthenticationService) { }

  ngOnInit() {
    this.user = this.authService.getCurrentUser();
  }

  onAddRound(){
  }

  onSaveAll(): void {
    this.editMode = !this.editMode;
  }



}
