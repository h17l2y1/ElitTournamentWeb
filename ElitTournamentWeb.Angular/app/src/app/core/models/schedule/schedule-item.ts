import {GameItem} from '../game/game-item';

export class ScheduleItem {
    place: string;
    date: Date;
    games: Array<GameItem>;

    constructor(place: string, data: Date, games: Array<GameItem>) {
        this.place = place;
        this.date = data;
        this.games = games;
    }
}
