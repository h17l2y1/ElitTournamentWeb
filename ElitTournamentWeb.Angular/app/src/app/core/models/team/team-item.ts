import { PlayerItem } from '../player/player-item';

export class TeamItem {
    position?: number;
    icon: string;
    name: string;
    played?: number;
    won?: number;
    drawn?: number;
    lost?: number;
    goals?: number;
    goalDifference?: number;
    points?: number;
    players: Array<PlayerItem>;
    leagueId?: number;
}
