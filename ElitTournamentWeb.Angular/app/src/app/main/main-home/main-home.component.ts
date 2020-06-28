import {Component, OnInit} from '@angular/core';
import {AuthenticationService} from 'src/app/core/services/auth.service';
import {PostService} from '../../core/services/post.service';
import {TokenData} from 'src/app/core/models/token-data';
import {GetAllPostItemResponse} from '../../core/models/get-all-post-response';

export interface Tile {
    color: string;
    cols: number;
    rows: number;
    text: string;
}

@Component({
    selector: 'app-main-home',
    templateUrl: './main-home.component.html',
    styleUrls: ['./main-home.component.css']
})
export class MainHomeComponent implements OnInit {

    constructor(private authService: AuthenticationService, private postService: PostService) {
    }

    public user: TokenData;
    public postsTypeZero: Array<GetAllPostItemResponse>;
    public postsTypeOne: Array<GetAllPostItemResponse>;
    public postsTypeTwo: Array<GetAllPostItemResponse>;
    public postsTypeThree: Array<GetAllPostItemResponse>;
    public postsTypeFour: Array<GetAllPostItemResponse>;

    ngOnInit() {
        this.user = this.authService.getCurrentUser();
        this.getAllPosts();
    }

    public getAllPosts(): void {
        this.postService.getAll().subscribe(response => {
            this.postsTypeZero = response.posts.filter(post => post.type === 0);
            this.postsTypeOne = response.posts.filter(post => post.type === 1);
            this.postsTypeTwo = response.posts.filter(post => post.type === 2);
            this.postsTypeThree = response.posts.filter(post => post.type === 3);
            this.postsTypeFour = response.posts.filter(post => post.type === 4);
        });
    }

    public editPost(post: GetAllPostItemResponse){
        post.editMode = true;
    }

    public savePost(post: GetAllPostItemResponse){
        post.editMode = false;
        // this.postService.update().subscribe(response => {
        //
        // });
    }

    public clearPost(post: GetAllPostItemResponse){
        post.editMode = false;
    }

}
