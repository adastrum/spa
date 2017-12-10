import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatTableDataSource } from '@angular/material';
import { Foo } from "./foo";
import { Bar } from "./bar";

@Component({
    selector: 'foos',
    templateUrl: './foos.component.html'
})
export class FoosComponent implements OnInit {

    foos: Foo[];
    fooDataSource: MatTableDataSource<Foo>;
    displayedColumns = ['id', 'name', 'description'];

    constructor(private http: HttpClient) {
    }

    public ngOnInit(): void {
        this.http.get('http://spa.api.local/foos').subscribe(data => {
            console.log(data);
            this.foos = <Foo[]>data;
            this.fooDataSource = new MatTableDataSource(this.foos);
        });
    }
}
