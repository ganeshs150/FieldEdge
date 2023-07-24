import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from 'src/app/api.service';

@Component({
  selector: 'app-view-customers',
  templateUrl: './view-customers.component.html',
  styleUrls: ['./view-customers.component.css']
})
export class ViewCustomersComponent {
  customers: any = [];
  constructor(private apiService: ApiService, private router: Router) { }

  ngOnInit() {
   this.getCustomers();
  }

  public getCustomers(){
    this.apiService.getCustomers().subscribe((data) => {
      if (data) {
        this.customers = data;
      }
    });
  }

  public deleteCustomer(id: number) {
    if(confirm("Are you sure to delete")) {
      this.apiService.deleteCustomerById(id).subscribe((data) => {
        if (data) {
          this.getCustomers();
        }
      });
    }
  }

}
