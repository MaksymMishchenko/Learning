import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Post } from 'src/app/shared/interfaces';
import { PostsService } from 'src/app/shared/posts.service';

@Component({
  selector: 'app-create-page',
  templateUrl: './create-page.component.html',
  styleUrls: ['./create-page.component.scss']
})
export class CreatePageComponent implements OnInit {
  constructor(private postsService: PostsService) { }
  form!: FormGroup

  ngOnInit() {
    this.form = new FormGroup({
      title: new FormControl('', [Validators.required]),
      category: new FormControl('', [Validators.required]),
      text: new FormControl('', [Validators.required]),
      author: new FormControl('', [Validators.required])
    });
  }

  submit() {
    if (this.form.invalid) {
      return;
    }

    const post: Post = {
      title: this.form.value.title,
      category: this.form.value.category,
      text: this.form.value.text,
      author: this.form.value.author,
      date: new Date()
    }

    this.postsService.create(post).subscribe(() => {
      this.form.reset();
    });
  }
}
