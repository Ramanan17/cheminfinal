import { Component, OnInit } from '@angular/core';
import { DataserviceService } from "../../services/dataservice.service"

@Component({
  selector: "app-datatables",
  templateUrl: './datatables.component.html',
  styleUrls: ['./datatables.component.css']
})
export class DatatablesComponent implements OnInit {

 sites:any[];
  constructor(public dataservice: DataserviceService) {
      this.dataservice.getSites().subscribe(m => {
          this.sites = m;
          console.log(this.sites);
      });
  }

  ngOnInit() {
  }

}
