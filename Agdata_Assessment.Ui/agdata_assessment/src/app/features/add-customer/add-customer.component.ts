import { Component } from '@angular/core';
import { AddCustomerRequest } from '../models/add-customer-request.model';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-add-customer',
  templateUrl: './add-customer.component.html',
  styleUrls: ['./add-customer.component.css']
})
export class AddCustomerComponent {

  model: AddCustomerRequest;

  constructor(private customerService: CustomerService){
    this.model = {
      name: '',
      address: ''
    };
  }



  onAddCustomerFormSubmit() {
    //console.log(this.model);

    this.customerService.addCustomer(this.model);
  }



}
