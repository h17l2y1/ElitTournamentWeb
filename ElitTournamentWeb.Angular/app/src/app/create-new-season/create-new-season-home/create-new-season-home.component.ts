import {Component, OnInit} from '@angular/core';
import {LeagueService} from '../../core/services/league.service';
import {TeamService} from 'src/app/core/services/team.service';
import {TeamItem} from '../../core/models/team/team-item';
import {LeagueItem} from 'src/app/core/models/league/league-item';
import {FormArray, FormBuilder, FormControl, FormGroup} from '@angular/forms';
import {Season} from 'src/app/core/models/season/season';
import {SeasonService} from '../../core/services/season.service';

@Component({
    selector: 'app-create-new-season-home',
    templateUrl: './create-new-season-home.component.html',
    styleUrls: ['./create-new-season-home.component.css']
})
export class CreateNewSeasonHomeComponent implements OnInit {

    public leagues: Array<LeagueItem>;
    public allTeams: Array<TeamItem>;
    public season: Season;
    public seasonForm: FormGroup;

    //
    toppings = new FormControl();
    displayedColumns: string[] = ['name'];
    // dataSource = ELEMENT_DATA;
    //


    constructor(private leagueService: LeagueService,
                private teamService: TeamService,
                private formBuilder: FormBuilder,
                private seasonService: SeasonService) {
    }

    ngOnInit() {
        this.getAllTeams();
        this.initForm()

        this.season = new Season();
    }

    public getAllTeams(): void {
        this.teamService.getAll().subscribe(response => {
            this.allTeams = response.teams;
        });
    }

    public initForm(): void {
        this.seasonForm = this.formBuilder.group({
            name: '',
            leagues: this.formBuilder.array([
                this.formBuilder.group({
                    name: this.formBuilder.control(''),
                    teams: this.formBuilder.control('')
                })
            ])
        });
    }

    get getLeagues(): FormArray {
        return this.seasonForm.get('leagues') as FormArray;
    }

    public addDefaultLeague(): void {
        this.getLeagues.push(
            this.formBuilder.group({
                name: this.formBuilder.control(''),
                teams: this.formBuilder.control(new Array<TeamItem>())
            })
        );
    }

    public saveNewLeague(): void{
        const request = new Season();
        request.name = this.seasonForm.value.name;
        request.leagues = this.seasonForm.value.leagues;

        this.seasonService.create(request).subscribe();
    }

}
