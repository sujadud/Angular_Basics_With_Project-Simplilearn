import { Component } from '@angular/core';
import { RecordsService } from '../records.service';

@Component({
  selector: 'app-emp-info',
  templateUrl: './emp-info.component.html',
  styleUrls: ['./emp-info.component.css'],
  providers: [RecordsService]
})
export class EmpInfoComponent {

  infoRecived1: string[] = [];
  infoRecived2: string[] = [];
  infoRecived3: string[] = [];

  getInfoFromServiceClass1(){
    this.infoRecived1 = this.rservice.getinfo1()
  }

  getInfoFromServiceClass2(){
    this.infoRecived2 = this.rservice.getinfo2()
  }

  getInfoFromServiceClass3(){
    this.infoRecived3 = this.rservice.getinfo3()
  }

  /**
   *
   */
  constructor(private rservice: RecordsService) {
    
    
  }

  ngOnInit(): void {
    
  }


}
