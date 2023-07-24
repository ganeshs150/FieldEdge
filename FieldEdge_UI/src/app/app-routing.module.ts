import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewCustomersComponent } from './customer/view-customers/view-customers.component';
import { EditCustomerComponent } from './customer/edit-customer/edit-customer.component';

const routes: Routes = [
  { path: 'customer', component: ViewCustomersComponent },
  { path: 'customer/edit/:id', component: EditCustomerComponent },
  { path: '', redirectTo: '/customer', pathMatch: 'full' },
  { path: '**', redirectTo: '/customer' },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
