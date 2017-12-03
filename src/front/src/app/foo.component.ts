import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { Foo } from "./foo";
import { Bar } from "./bar";

@Component({
    selector: 'foo',
    templateUrl: './foo.component.html'
})
export class FooComponent implements OnInit {
    foo: Foo;
    constructor(
        private route: ActivatedRoute,
        private http: HttpClient
    ) {
    }

    public ngOnInit(): void {
        const id = +this.route.snapshot.paramMap.get('id');
        this.http.get(`http://spa.local/foos/${id}`).subscribe(data => {
            console.log(data);
            this.foo = <Foo>data;
        });
    }
}