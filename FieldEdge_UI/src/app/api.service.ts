import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  //baseUrl = "https://getinvoices.azurewebsites.net/api/";
  baseUrl = "https://localhost:44347/api/";

  constructor(private httpClient: HttpClient) {
  }

  public getCustomers() {
    let url = this.baseUrl + "Customer";
    return this.httpClient.get(url);
  }

  public getCustomerById(customerId: number) {
    let url = this.baseUrl + "Customer/" + customerId;
    return this.httpClient.get(url);
  }

  public upsertCustomer(customer: any) {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
    });
    let options = { headers: headers };

    let url = this.baseUrl + "Customer";
    return this.httpClient.post<any>(url, customer, options);
  }

  public deleteCustomerById(customerId: number) {
    let url = this.baseUrl + "Customer/" + customerId;
    return this.httpClient.delete(url);
  }

}
