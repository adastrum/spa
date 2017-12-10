import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { MatTableDataSource } from '@angular/material';
import { Foo } from "./foo";
import { Bar } from "./bar";

@Component({
    selector: 'foo',
    templateUrl: './foo.component.html'
})
export class FooComponent implements OnInit {

    foo: Foo;
    barDataSource: MatTableDataSource<Bar>;
    displayedColumns = ['name', 'amount'];

    constructor(
        private route: ActivatedRoute,
        private http: HttpClient
    ) {
    }

    public ngOnInit(): void {
        const id = +this.route.snapshot.paramMap.get('id');
        this.http.get(`http://spa.api.local/foos/${id}`).subscribe(data => {
            console.log(data);
            this.foo = <Foo>data;
            this.barDataSource = new MatTableDataSource<Bar>(this.foo.bars);
        });
    }
}