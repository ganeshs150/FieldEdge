import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewCustomersComponent } from './customer/view-customers/view-customers.component';

const routes: Routes = [
  {path: 'customer', component: ViewCustomersComponent},
  { path: '', redirectTo:'/customer',pathMatch:'full' },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
