import { Injectable } from "@angular/core";  
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http'; 

@Injectable()
export class ParkingLocationService { 

    constructor(public http: HttpClient) { }

    getAllParkingLocations(){

        return this.http.get("http://v-koppoluv-01:61372/api/Location/GetAllLocations", {observe : 'response'})

    }

    loadData(){

    }

    addEntry(){
        
    }
    exitEntry(){
        
    }
}