import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Computer } from '../Intefaces/computer.model';
import { ComputerService } from '../services/computer.service';

@Component({
  selector: 'app-view-computer',
  templateUrl: './view-computer.component.html',
  styleUrls: ['./view-computer.component.scss']
})

export class ViewComputerComponent implements OnInit {

  displayedColumns: string[] = ['computerId', 'cpu', 'ram', 'gpu', 'case', 'psu', 'motherboard', 'os', 'ownerId'];
  dataSource: MatTableDataSource<Computer>;

  applyFilter(event: Event): void {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  constructor(private computerService: ComputerService) { }

  ngOnInit(): void {
    this.computerService.getComputers().subscribe(x => {
      this.dataSource = new MatTableDataSource(x);
    });
  }

}
