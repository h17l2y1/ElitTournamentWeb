import { Component, OnInit } from '@angular/core';

export interface PeriodicElement {
  position: number;
  name: string;
  played: number;
  won: number;
  drawn: number;
  lost: number;
  goals: number;
  goalDifference: number;
  points: number;
  statistics: Statistic[];
}

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

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Если Шо', played: 3, won: 2, drawn: 1, lost: 0, goals: 8, goalDifference: 3, points: 7, statistics: Statistic_DATA },
  {position: 2, name: 'Tenko Team', played: 3, won: 2, drawn: 1, lost: 0, goals: 8, goalDifference: 3, points: 6, statistics: Statistic_DATA },
  {position: 3, name: 'ХПС', played: 3, won: 2, drawn: 1, lost: 0, goals: 8, goalDifference: 3, points: 4, statistics: Statistic_DATA },
  {position: 4, name: '5.10', played: 3, won: 2, drawn: 1, lost: 0, goals: 8, goalDifference: 3, points: 3, statistics: Statistic_DATA },
  {position: 5, name: 'Олимп', played: 3, won: 2, drawn: 1, lost: 0, goals: 8, goalDifference: 3, points: 3, statistics: Statistic_DATA },
  {position: 6, name: 'Трансинвест', played: 3, won: 2, drawn: 1, lost: 0, goals: 8, goalDifference: 3, points: 0, statistics: Statistic_DATA },
  {position: 7, name: 'H.P', played: 3, won: 2, drawn: 1, lost: 0, goals: 8, goalDifference: 3, points: 0, statistics: Statistic_DATA },
];



@Component({
  selector: 'app-dashboard-home',
  templateUrl: './dashboard-home.component.html',
  styleUrls: ['./dashboard-home.component.css']
})
export class DashboardHomeComponent implements OnInit {

  displayedColumns: string[] = ['position', 'name', 'played', 'won', 'drawn', 'lost', 'goals', 'goalDifference', 'points', 'statistics'];
  dataSource = ELEMENT_DATA;

  constructor() {
  }

  ngOnInit() {
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
