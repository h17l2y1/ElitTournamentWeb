import {Component, OnInit} from '@angular/core';
import {AuthenticationService} from 'src/app/core/services/auth.service';
import {PostService} from '../../core/services/post.service';
import {TokenData} from 'src/app/core/models/token-data';
import {GetAllPostResponse} from '../../core/models/post/get-all-post-response';
import {FormArray, FormBuilder, FormGroup, AbstractControl} from '@angular/forms';
import {UpdateManyPostRequest, UpdateManyPostItem} from 'src/app/core/models/post/update-many-post-request';

@Component({
    selector: 'app-main-home',
    templateUrl: './main-home.component.html',
    styleUrls: ['./main-home.component.css']
})
export class MainHomeComponent implements OnInit {

    public postsForm: FormGroup;
    public editMode: boolean;
    public user: TokenData;
    public response: GetAllPostResponse;
    public removed: Array<UpdateManyPostItem>;

    constructor(private authService: AuthenticationService, private postService: PostService, private formBuilder: FormBuilder) {
    }

    ngOnInit() {
        this.initForm();
        this.getAllPosts();
        this.user = this.authService.getCurrentUser();

        this.removed = new Array<UpdateManyPostItem>();
    }

    initForm() {
        this.postsForm = this.formBuilder.group({
            posts: this.formBuilder.array([]),
        });
    }

    public getAllPosts(): void {
        this.postService.getAll().subscribe(response => {
            this.response = response;
            this.addPostsToFormArray();
        });
    }

    public addPostsToFormArray() {
        this.response.posts.forEach(post => {
            this.posts.push(
                this.formBuilder.group({
                    id: post.id,
                    type: post.type,
                    title: post.title,
                    text: post.text,
                    editMode: false,
                    removed: false
                })
            );
        });
    }

    get posts(): FormArray {
        return this.postsForm.get('posts') as FormArray;
    }

    getControls(): Array<AbstractControl> {
        const form = this.postsForm.get('posts') as FormArray;
        return form.controls;
    }

    addPost(type: number) {
        this.posts.push(
            this.formBuilder.group({
                id: 0,
                type: type,
                title: '',
                text: '',
                editMode: false,
                removed: false,
            })
        );
    }

    public removePost(i: number) {
        const removedPost = this.posts.value[i] as UpdateManyPostItem;
        this.removed.push(removedPost)
        this.posts.removeAt(i);
    }

    public saveAll() {
        this.editMode = !this.editMode;
        const editedControls = this.posts.controls.filter(x => x.dirty) as Array<AbstractControl>;

        const updatedPosts = editedControls.map(control => ({
            id: control.value.id,
            type: control.value.type,
            title: control.value.title,
            text: control.value.text,
            description: control.value.description,
            image: control.value.image
        } as UpdateManyPostItem));

        const request = new UpdateManyPostRequest(updatedPosts, this.removed);

        this.postService.updateMany(request).subscribe();
    }
}
