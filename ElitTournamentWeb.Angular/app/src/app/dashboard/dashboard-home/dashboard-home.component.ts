import { Component, OnInit } from '@angular/core';
import { LeagueService } from 'src/app/core/services/league.service';
import {AuthenticationService} from '../../core/services/auth.service';
import {LeagueItem} from '../../core/models/league/league-item';
import { GetAllLeaguesResponse } from 'src/app/core/models/league/get-all-leagues-response';

export interface Statistic {
  stat: string;
}
const Statistic_DATA: Statistic[] = [
  {stat: 'В'},
  {stat: 'В'},
  {stat: 'П'},
  {stat: 'В'},
  {stat: 'Н'},
];

@Component({
  selector: 'app-dashboard-home',
  templateUrl: './dashboard-home.component.html',
  styleUrls: ['./dashboard-home.component.css']
})
export class DashboardHomeComponent implements OnInit {

  public leagueView :GetAllLeaguesResponse;
  public leagues :Array<LeagueItem>;

  displayedColumns: string[] = ['position', 'name', 'played', 'won', 'drawn', 'lost', 'goals', 'goalDifference', 'points' /*, 'statistics'*/];

  constructor(private authService: AuthenticationService, private leagueService: LeagueService) {
  }

  ngOnInit() {
    this.getAllLeagues();
  }

  public getAllLeagues(){
    this.leagueService.getAll().subscribe(response => {
      this.leagueView = response;
      this.leagues = response.leagues;
    })
  }

  public getClass(stat: string): string{
    if (stat === 'В'){
      return 'statistic win'
    }
    if (stat === 'П'){
      return 'statistic lose'
    }
    if (stat === 'Н'){
      return 'statistic draw'
    }
  }

}
