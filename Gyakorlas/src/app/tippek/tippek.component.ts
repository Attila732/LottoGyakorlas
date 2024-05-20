import { Component, Input } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-tippek',
  templateUrl: './tippek.component.html',
  styleUrls: ['./tippek.component.css']
})
export class TippekComponent {
  oszlopok=["sz1","sz2","sz3","sz4","sz5","sz6"]
  newTipp:any={}
  @Input() tippek:any



  constructor(private base:BaseService){

  }
  updateTipp(tipp:any){
    this.base.updateTipp(tipp)
  }


  deleteTipp(tipp:any){
    this.base.deleteTipp(tipp)
  }

  createTipp(){
    this.newTipp.jatekosId=this.tippek[0].jatekosId
    this.base.newTipp(this.newTipp)
  }
}
