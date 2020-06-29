export class GetAllPostResponse {
    public posts: Array<GetAllPostItemResponse>;
}

export class GetAllPostItemResponse {
    public id: number;
    public type: number;
    public title: string;
    public description: string;
    public text: string;
    public image: string;
    public editMode: boolean;
}
