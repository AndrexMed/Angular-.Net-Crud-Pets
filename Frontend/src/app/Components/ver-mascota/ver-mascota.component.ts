import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable, Subscription } from 'rxjs';
import { Mascota } from 'src/app/Interfaces/mascota';
import { MascotaService } from 'src/app/Services/mascota.service';

@Component({
  selector: 'app-ver-mascota',
  templateUrl: './ver-mascota.component.html',
  styleUrls: ['./ver-mascota.component.css']
})
export class VerMascotaComponent implements OnInit, OnDestroy {

  id!: number
  mascota!: Mascota

  loading : boolean = false

  mascota$! : Observable<Mascota> //Pipe async

  routeSub! : Subscription

  constructor(private _mascotaService: MascotaService,
    private aRoute: ActivatedRoute) {
    this.id = +this.aRoute.snapshot.paramMap.get("id")! // con "+" y !, lo parseamos a int
    //console.log(this.id)
  }
  
  ngOnDestroy(): void {
   //this.routeSub.unsubscribe()
  }

  ngOnInit(): void {
    // this.aRoute.params.subscribe(data => {
    //   console.log(data)
    //   this.id = data['id']
    //   this.obtenerMascota()
    // })
    this.obtenerMascota()
    //this.mascota$ = this._mascotaService.getMascota(this.id) //Pipe async
  }

  obtenerMascota() {
    this.loading = true
    this._mascotaService.getMascota(this.id).subscribe({
      next: (response) => {
        console.log(response)
        this.mascota = response
        this.loading = false
      },
      error: (e) => {
        alert("Ocurrio un error en el servidor!")
        alert("Oops ocurrio un error al obtener la mascota!")
      },
      complete: () => {
        console.log("Transaccion Exitosa!")
      }
    })
  }

}
