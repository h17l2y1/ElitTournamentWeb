import { PostType } from '../types/post-type';

export class UpdateManyPostRequest {
    public posts: Array<UpdateManyPostItem>;
    public removedPosts: Array<UpdateManyPostItem>;

    constructor(posts: Array<UpdateManyPostItem>, removedPosts: Array<UpdateManyPostItem>) {
        this.posts = posts;
        this.removedPosts = removedPosts;
    }
}

export class UpdateManyPostItem {
    public id: number;
    public type: PostType;
    public title: string;
    public description: string;
    public text: string;
    public image: string;
}

