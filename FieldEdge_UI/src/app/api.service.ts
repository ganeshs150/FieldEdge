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

}
