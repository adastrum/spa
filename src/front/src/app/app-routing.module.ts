import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FoosComponent } from "./foos.component";
import { FooComponent } from "./foo.component";

const routes: Routes = [
  { path: '', redirectTo: '/foos', pathMatch: 'full' },
  { path: 'foos', component: FoosComponent, pathMatch: 'full' },
  { path: 'foos/:id', component: FooComponent, pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
