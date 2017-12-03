import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Foo } from "./foo";
import { Bar } from "./bar";

@Component({
    selector: 'foos',
    templateUrl: './foos.component.html'
})
export class FoosComponent implements OnInit {
    foos: Foo[];
    constructor(private http: HttpClient) {
    }

    public ngOnInit(): void {
        this.http.get('http://spa.local/foos').subscribe(data => {
            console.log(data);
            this.foos = <Foo[]>data;
        });
    }
}
