import { Component, OnDestroy } from '@angular/core';
import { BaseService } from '../base.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-jatekosok',
  templateUrl: './jatekosok.component.html',
  styleUrls: ['./jatekosok.component.css']
})
export class JatekosokComponent implements OnDestroy {
  feliratkozas:Subscription
  gamers:any



  constructor(private base:BaseService){
    this.feliratkozas=base.getGamers().subscribe(
      (res:any)=>this.gamers=res
    )
  }

  ngOnDestroy(): void {
      if( this.feliratkozas){this.feliratkozas.unsubscribe()}
  }


}
