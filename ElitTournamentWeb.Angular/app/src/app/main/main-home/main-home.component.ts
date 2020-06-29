import {Component, OnInit} from '@angular/core';
import {AuthenticationService} from 'src/app/core/services/auth.service';
import {PostService} from '../../core/services/post.service';
import {TokenData} from 'src/app/core/models/token-data';
import {GetAllPostItemResponse, GetAllPostResponse} from '../../core/models/get-all-post-response';
import {FormArray, FormBuilder, FormGroup, FormControl} from '@angular/forms';
import {forEach} from '@angular-devkit/schematics';

@Component({
    selector: 'app-main-home',
    templateUrl: './main-home.component.html',
    styleUrls: ['./main-home.component.css']
})
export class MainHomeComponent implements OnInit {

    postForm: FormGroup;

    constructor(private authService: AuthenticationService, private postService: PostService, private formBuilder: FormBuilder) {
    }

    public user: TokenData;
    public response: GetAllPostResponse;
    public postsTypeZero: Array<GetAllPostItemResponse>;
    public postsTypeOne: Array<GetAllPostItemResponse>;
    public postsTypeTwo: Array<GetAllPostItemResponse>;
    public postsTypeThree: Array<GetAllPostItemResponse>;
    public postsTypeFour: Array<GetAllPostItemResponse>;

    ngOnInit() {
        this.initForm();
        this.user = this.authService.getCurrentUser();
        this.getAllPosts();

    }

    public getAllPosts(): void {
        this.postService.getAll().subscribe(response => {
            this.response = response;
            this.postsTypeZero = response.posts.filter(post => post.type === 0);
            this.postsTypeOne = response.posts.filter(post => post.type === 1);
            this.postsTypeTwo = response.posts.filter(post => post.type === 2);
            this.postsTypeThree = response.posts.filter(post => post.type === 3);
            this.postsTypeFour = response.posts.filter(post => post.type === 4);

            this.addPostForm();
        });
    }
    trackByFn(index: any, item: any) {
        return index;
    }
    initForm(){
        this.postForm = this.formBuilder.group({
            formControlArray: this.formBuilder.array([]),
        });
    }

    addPostForm(){
        const creds = this.postForm.controls.formControlArray as FormArray;

        this.response.posts.forEach(post => {
            creds.push(this.formBuilder.group({
                title: new FormControl(post.title),
                text: new FormControl(post.text)
            }));
        });
    }

    public editPost(post: GetAllPostItemResponse){
        post.editMode = true;
    }

    public savePost(index: number, post: GetAllPostItemResponse){
        post.editMode = false;
        var formControlArray = this.postForm.controls.formControlArray as FormArray;

        post.title = formControlArray.controls[index].value.title;
        post.text = formControlArray.controls[index].value.text;

        this.postService.update(post).subscribe(response => {

        });
    }

    public clearPost(post: GetAllPostItemResponse){
        post.editMode = false;
    }

}
