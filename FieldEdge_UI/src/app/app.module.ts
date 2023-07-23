import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViewCustomersComponent } from './customer/view-customers/view-customers.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ButtonModule } from 'primeng/button';
import { NgbAlertModule, NgbModule, NgbTooltipModule } from '@ng-bootstrap/ng-bootstrap';
import { ApiService } from './api.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    ViewCustomersComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ButtonModule,
    NgbModule,
    NgbAlertModule ,
    NgbTooltipModule,
    HttpClientModule 
  ],
  providers: [ApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
