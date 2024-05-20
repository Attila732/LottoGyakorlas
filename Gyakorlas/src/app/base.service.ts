import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  url="https://localhost:7254/api/Jatekos/"
  tippUrl="https://localhost:7254/api/Tipps/"

  private jatekosokSub=new BehaviorSubject(null)


  constructor(private http:HttpClient) {
    this.loadJatekos();
   }


  private loadJatekos(){
    this.http.get(this.url).subscribe(
      (res:any)=>this.jatekosokSub.next(res)
    )
  }
  
  public getGamers(){
    return this.jatekosokSub
  }

  public newTipp(tipp:any){
    this.http.post(this.tippUrl,tipp).forEach(
      ()=>this.loadJatekos()
    )
  }


  public deleteTipp(tipp:any){
    this.http.delete(this.tippUrl+tipp.id).forEach(
      ()=>this.loadJatekos()
    )
  }

  public updateTipp(tipp:any){
    this.http.put(this.tippUrl+tipp.id,tipp).forEach(
      ()=>this.loadJatekos()
    )
  }

}
