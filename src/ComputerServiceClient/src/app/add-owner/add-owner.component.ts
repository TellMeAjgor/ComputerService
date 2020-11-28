import { Component, OnInit } from '@angular/core';
import { OwnerService } from '../services/owner.service';
import { Owner } from '../Intefaces/owner.model';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-add-owner',
  templateUrl: './add-owner.component.html',
  styleUrls: ['./add-owner.component.scss'],
})
export class AddOwnerComponent implements OnInit {

  constructor(private service: OwnerService, private fb: FormBuilder) { }
  owner: any;
  register = new FormGroup({
    email: new FormControl(''),
    password: new FormControl(''),
    name: new FormControl('')
  });
  ngOnInit(): void {  }

  AddOwner(): void {
    this.service.addOwner(this.register.value).subscribe(x => {
      console.log(x);
    });
  }
}
