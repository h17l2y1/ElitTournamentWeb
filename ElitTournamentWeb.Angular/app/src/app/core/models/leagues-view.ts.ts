export interface GetAllLeaguesResponse {
    leagues: Array<LeagueItem>;
}

export interface LeagueItem {
    name: string;
    teams: Array<TeamItem>;
}

export interface TeamItem {
    position: number;
    icon: string;
    name: string;
    played: number;
    won: number;
    drawn: number;
    lost: number;
    goals: number;
    goalDifference: number;
    points: number;
    players: Array<PlayerItem>;
    leagueId: number;
}

export interface PlayerItem {
    firstName: string;
    lastName: string;
    age: number;
}
