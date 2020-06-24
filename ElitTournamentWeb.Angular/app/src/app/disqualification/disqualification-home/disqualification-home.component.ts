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
];

@Component({
  selector: 'app-disqualification-home',
  templateUrl: './disqualification-home.component.html',
  styleUrls: ['./disqualification-home.component.css']
})
export class DisqualificationHomeComponent implements OnInit {
  panelOpenState = false;
  displayedColumns: string[] = ['position', 'name', 'team', 'goals'];
  dataSource = ELEMENT_DATA;
  constructor() { }

  ngOnInit() {
  }

}
