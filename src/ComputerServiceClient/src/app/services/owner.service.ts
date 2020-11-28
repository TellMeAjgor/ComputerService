import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Owner } from '../Intefaces/owner.model';

@Injectable({
  providedIn: 'root'
})
export class OwnerService {

 constructor(private http: HttpClient) { }

 addOwner(model: any) {
  return this.http.post('http://localhost:59234/api/owner', model);
 }

}
