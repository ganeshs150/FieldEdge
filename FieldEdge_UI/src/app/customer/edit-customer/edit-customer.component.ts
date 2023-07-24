import { Component, ViewChild, ElementRef } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiService } from 'src/app/api.service';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Customer } from 'src/app/models/customer';

@Component({
  selector: 'app-edit-customer',
  templateUrl: './edit-customer.component.html',
  styleUrls: ['./edit-customer.component.css']
})
export class EditCustomerComponent {
  customerId: any;
  formSubmitted: any;

  constructor(private apiService: ApiService, private router: Router, private activatedRoute: ActivatedRoute, private fb: FormBuilder) { }

  customerForm = new FormGroup({
    firstname: new FormControl(''),
    lastname: new FormControl(''),
    email: new FormControl('', [Validators.email, Validators.required]),
    phone_number: new FormControl(''),
    country_code: new FormControl(''),
    gender: new FormControl(''),
  });

  get f() {
    return this.customerForm.controls;
  }

  ngOnInit() {

    this.activatedRoute.params.subscribe((param) => {
      this.customerId = param['id'];
    });

    this.apiService.getCustomerById(this.customerId).subscribe((data: any) => {
      if (data) {
        this.customerForm.patchValue({
          firstname: data.firstname,
          lastname: data.lastname,
          gender: data.gender,
          email: data.email,
          country_code: data.country_code,
          phone_number: data.phone_number,
        });
      }
    });

  }

  onSubmit() {
    this.formSubmitted = true;
    if (this.customerForm.valid) {
      let customer = new Customer();
      if (this.customerId == 0)
        customer.id = 0;
      else
        customer.id = this.customerId;

      customer.firstname = this.customerForm.value.firstname;
      customer.lastname = this.customerForm.value.lastname;
      customer.gender = this.customerForm.value.gender;
      customer.email = this.customerForm.value.email;
      customer.country_code = this.customerForm.value.country_code;
      customer.phone_Number = this.customerForm.value.phone_number;

      this.apiService.upsertCustomer(customer).subscribe((data) => {
        if (data) {
          this.router.navigate(['customer']);
        }
      });
    }
    else {
      alert('Please check the validation warning');
    }
  }

}


