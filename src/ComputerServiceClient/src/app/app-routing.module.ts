import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddOwnerComponent } from './add-owner/add-owner.component';
import { ViewComputerComponent } from './view-computer/view-computer.component';

const routes: Routes = [
  {
    path: '',
    component: ViewComputerComponent
  },
  {
    path: 'addowner',
    component: AddOwnerComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
