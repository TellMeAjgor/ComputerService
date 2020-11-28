import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Computer } from '../Intefaces/computer.model';

@Injectable({
  providedIn: 'root'
})
export class ComputerService {

 constructor(private http: HttpClient) { }

 getComputers(): Observable<Computer[]> {
   return this.http.get<Computer[]>('http://localhost:59234/api/computer');
  }

}
