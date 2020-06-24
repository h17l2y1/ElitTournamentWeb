import { Component, OnInit } from '@angular/core';

export interface PeriodicElement {
  position: number;
  name: string;
  team: string;
  goals: number;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', team: 'Hydrogen', goals: 9},
  {position: 2, name: 'Helium', team: 'Hydrogen', goals: 9},
  {position: 3, name: 'Lithium', team: 'Hydrogen', goals: 8},
  {position: 4, name: 'Beryllium', team: 'Hydrogen', goals: 7},
  {position: 5, name: 'Boron', team: 'Hydrogen', goals: 7},
  {position: 6, name: 'Carbon', team: 'Hydrogen', goals: 7},
  {position: 7, name: 'Nitrogen', team: 'Hydrogen', goals: 6},
  {position: 8, name: 'Oxygen', team: 'Hydrogen', goals: 6},
  {position: 9, name: 'Fluorine', team: 'Hydrogen', goals: 6},
  {position: 10, name: 'Neon', team: 'Hydrogen', goals: 6},
];

@Component({
  selector: 'app-statistic-home',
  templateUrl: './statistic-home.component.html',
  styleUrls: ['./statistic-home.component.css']
})
export class StatisticHomeComponent implements OnInit {

  displayedColumns: string[] = ['position', 'name', 'team', 'goals'];
  dataSource = ELEMENT_DATA;

  constructor() { }

  ngOnInit() {
  }

}
