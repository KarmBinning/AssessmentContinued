import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerListComponent } from './features/customer/customer-list/customer-list.component';
import { AddCustomerComponent } from './features/add-customer/add-customer.component';

const routes: Routes = 
[
  {
    path: 'admin/customers',
    component: CustomerListComponent
  },
  {
    path: 'admin/customers/add',
    component: AddCustomerComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
