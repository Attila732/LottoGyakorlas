import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JatekosokComponent } from './jatekosok/jatekosok.component';

const routes: Routes = [
  {path:"",component:JatekosokComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
