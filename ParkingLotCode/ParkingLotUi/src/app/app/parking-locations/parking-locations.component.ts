import { Component, OnDestroy, OnInit } from '@angular/core';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http'; 
import { Subscriber, Subscription } from 'rxjs';
import { interval } from 'rxjs/internal/observable/interval';
import { ParkingLocationService } from '../services/parking.location.service';

@Component({
  selector: 'app-parking-locations',
  templateUrl: './parking-locations.component.html',
  styleUrls: ['./parking-locations.component.css']
})
export class ParkingLocationsComponent implements OnInit, OnDestroy {

  public data: any = [];  
  //public self = this;  
   //timeInterval: Subscription;

  constructor(public http: HttpClient, private parkingLocService: ParkingLocationService) { }
  

  ngOnInit(): void {
    //Polling

    // this.timeInterval = interval(1000).pipe(
    //   startwith(0),
    //   switchmap(() => this.parkingLocService.getAllParkingLocations())
    // ).subscribe(res => this.self.data = res , err => console.log("Error", err) )
    
  };

  ngOnDestroy(): void {
    //this.timeInterval.unsubscribe();
  }

  ngAfterViewInit(): void {  
    this.loadData();  
}

public loadData(): void{
    let self = this;
    debugger;
    this.http.get("http://v-koppoluv-01:61372/api/Location/GetAllLocations")  
    .subscribe(
        res => {  
        self.data = res;  
    }, error => {
    console.error(error)}); 
}

public onEntry(locId: number, avilableCount: number){

  if(avilableCount === 0){
    alert('Parking Location is Full!');
    return;
  }
  let self = this;  
  const httpOption =  {
      headers: new HttpHeaders({
          'Content-Type': 'application/json; charset=utf-8'
      })
    }
    debugger;
  this.http.put("http://v-koppoluv-01:61372/api/Location/UpdateEntry?id="+locId, null, httpOption)  
  .subscribe(res => {  
      self.loadData();  
  });
}

public onExit(locId: number, avilableCount: number, totalCount: number){
  if(avilableCount === totalCount){
    return;
  }
  let self = this;  
  const httpOption =  {
      headers: new HttpHeaders({
          'Content-Type': 'application/json; charset=utf-8'
      })
    }
  this.http.put("http://v-koppoluv-01:61372/api/Location/ExitEntry?id="+locId, null, httpOption)  
  .subscribe(res => {  
      self.loadData();  
  });
}

}
