import { Component, Input, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

@Component({
    selector: 'comment-form',
    templateUrl: './commentForm.component.html'
})
export class CommentFormComponent implements OnInit {
    @Input() submitLabel!: string;
    @Input() hasCancelButton: boolean = false;
    @Input() initialText: string = '';

    form!: FormGroup

    constructor(private fb: FormBuilder) { }

    ngOnInit(): void {
        this.form = this.fb.group({
            title: [this.initialText, Validators.required]
        });
    }

    onSubmit(): void {
        console.log('submit', this.form.value);
    }
}