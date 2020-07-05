import {Component, OnInit} from '@angular/core';
import {LeagueService} from '../../core/services/league.service';
import {TeamService} from 'src/app/core/services/team.service';
import {GetAllLeaguesResponse} from '../../core/models/league/get-all-leagues-response';
import {GetAllTeamsResponse} from 'src/app/core/models/team/get-all-teams-response';
import {TeamItem} from '../../core/models/team/team-item';
import { LeagueItem } from 'src/app/core/models/league/league-item';
import {CreateSeason} from '../../core/models/season/create-season';
import {FormBuilder, FormGroup} from '@angular/forms';
import {CdkDragDrop, moveItemInArray, transferArrayItem} from '@angular/cdk/drag-drop';

@Component({
    selector: 'app-create-new-season-home',
    templateUrl: './create-new-season-home.component.html',
    styleUrls: ['./create-new-season-home.component.css']
})
export class CreateNewSeasonHomeComponent implements OnInit {

    public leagueResponse: GetAllLeaguesResponse;
    public teamsResponse: GetAllTeamsResponse;
    public leagues: Array<LeagueItem>;
    public teams: Array<TeamItem>;
    public createSeason: CreateSeason;
    public onCreate: boolean;
    public seasonForm: FormGroup;

    constructor(private leagueService: LeagueService, private teamService: TeamService, private formBuilder: FormBuilder) {
    }

    ngOnInit() {
        this.initForm()
        this.getAllLeagues();
        this.getAllTeams();
    }

    initForm() {
        this.seasonForm = this.formBuilder.group({
            seasonName: '',
            leagues: this.formBuilder.array([]),
        });
    }

    public getAllLeagues() {
        this.leagueService.getAll().subscribe(response => {
            this.leagueResponse = response;
            this.leagues = response.leagues;
        });
    }

    public getAllTeams() {
        this.teamService.getAll().subscribe(response => {
            this.teamsResponse = response;
            this.teams = response.teams;
        });
    }

    public onCreateSeason(){
        this.createSeason = new CreateSeason();
    }

    public onAddNewLeague(){

    }







    todo = [
        'Get to work',
        'Pick up groceries',
        'Go home',
        'Fall asleep'
    ];

    done = [
        'Get up',
        'Brush teeth',
        'Take a shower',
        'Check e-mail',
        'Walk dog',
        'Get up',
        'Brush teeth',
        'Take a shower',
        'Check e-mail',
        'Walk dog',
        'Get up',
        'Brush teeth',
        'Take a shower',
        'Check e-mail',
        'Walk dog',
        'Get up',
        'Brush teeth',
        'Take a shower',
        'Check e-mail',
        'Walk dog',
        'Get up',
        'Brush teeth',
        'Take a shower',
        'Check e-mail',
        'Walk dog',
        'Get up',
        'Brush teeth',
        'Take a shower',
        'Check e-mail',
        'Walk dog',
    ];

    drop(event: CdkDragDrop<string[]>) {
        if (event.previousContainer === event.container) {
            moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
        } else {
            transferArrayItem(event.previousContainer.data,
                event.container.data,
                event.previousIndex,
                event.currentIndex);
        }
    }



}
