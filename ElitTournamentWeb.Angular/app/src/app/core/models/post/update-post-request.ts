import {PostType} from '../types/post-type';

export class UpdatePostRequest {
    public id: number;
    public type: PostType;
    public title: string;
    public description: string;
    public text: string;
    public image: string;
}
