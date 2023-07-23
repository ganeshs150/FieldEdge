import { Component } from '@angular/core';
import { NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { NgbAlertModule } from '@ng-bootstrap/ng-bootstrap';
import { ApiService } from 'src/app/api.service';

@Component({
  selector: 'app-view-customers',
  templateUrl: './view-customers.component.html',
  styleUrls: ['./view-customers.component.css']
})
export class ViewCustomersComponent {
  customers:any = [];
  constructor(private apiService: ApiService) { }

  ngOnInit() {

    this.apiService.getCustomers().subscribe((data)=>{
      console.log(data);
      this.customers = data;
    })  
  }

}
