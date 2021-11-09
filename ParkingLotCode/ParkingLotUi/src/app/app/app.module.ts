import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HttpClient, HttpHeaders  } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ParkingLocationsComponent } from './parking-locations/parking-locations.component';
import { ParkingLocationService } from './services/parking.location.service';

@NgModule({
  declarations: [
    AppComponent,
    ParkingLocationsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule 
  ],
  providers: [HttpClientModule, ParkingLocationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
