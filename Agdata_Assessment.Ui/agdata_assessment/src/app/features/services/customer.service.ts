import { Injectable } from '@angular/core';
import { AddCustomerRequest } from '../models/add-customer-request.model';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }

  addCustomer(model: AddCustomerRequest): Observable<void> {
    return this.http.post<void>('https://localhost:7023/api/Customer', model);
  }



}
