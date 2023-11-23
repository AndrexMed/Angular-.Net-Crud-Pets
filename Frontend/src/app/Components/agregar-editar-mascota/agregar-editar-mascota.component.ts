import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { Mascota } from 'src/app/Interfaces/mascota';
import { MascotaService } from 'src/app/Services/mascota.service';

@Component({
  selector: 'app-agregar-editar-mascota',
  templateUrl: './agregar-editar-mascota.component.html',
  styleUrls: ['./agregar-editar-mascota.component.css']
})
export class AgregarEditarMascotaComponent implements OnInit {

  loading: boolean = false

  formulario: FormGroup

  id: number
  operacion: string = "Agregar"

  constructor(private formu: FormBuilder,
    private _mascotaService: MascotaService,
    private _snackBar: MatSnackBar,
    private router: Router,
    private aRoute: ActivatedRoute) {
    this.formulario = this.formu.group({
      nombre: ["", Validators.required],
      raza: ["", Validators.required],
      color: ["", Validators.required],
      edad: ["", Validators.required],
      peso: ["", Validators.required]
    })
    this.id = +this.aRoute.snapshot.paramMap.get("id")!
    console.log(this.id)
  }

  ngOnInit(): void {
    if (this.id != 0) {
      this.operacion = "Editar"
      this.obtenerMascota(this.id)
    }
  }

  obtenerMascota(id: number) {
    this.loading = true
    this._mascotaService.getMascota(id).subscribe(
      response => {
        console.log(response)
        this.loading = false

        // this.formulario.patchValue({ // patchValue nos permite Setear uno o varios items del formulario.
        //   nombre: response.nombre
        // })

        this.formulario.setValue({ // SetValue nos obliga a Setear Todo el Formulario.
          nombre: response.nombre,
          color: response.color,
          raza: response.raza,
          edad: response.edad,
          peso: response.peso
        })
      },
      error => {

      }
    )
  }

  agregarOEditarMascota() {
    // const nombre = this.formulario.value.nombre
    // const nombre2 = this.formulario.get("nombre")?.value
    // console.log(nombre + "\n" + nombre2)
    const mascota: Mascota = {
      idMascota: this.id,
      nombre: this.formulario.value.nombre,
      raza: this.formulario.value.raza,
      color: this.formulario.value.color,
      edad: this.formulario.value.edad,
      peso: this.formulario.value.peso,
    }

    console.log(mascota)

    if (this.id != 0) {
      mascota.idMascota = this.id
      this.actualizarMascota(this.id, mascota)
      console.log("llego aqui xx", this.id)
    } else {
      this.agregarMascota(mascota)
    }
  }

  agregarMascota(mascota: Mascota) {
    //Enviamos los datos al back
    this._mascotaService.addMascota(mascota).subscribe(
      response => {
        console.log(response)
        this.mensajeExito("Agregada")
        this.router.navigate(["listadoMascotas"])
      },
      error => {
        alert("Ocurrio un erro el agregar la mascota!")
      }
    )
  }

  actualizarMascota(id: number, mascota: Mascota) {
    this.loading = true
    this._mascotaService.updateMascota(id, mascota).subscribe(
      respuesta => {
        this.mensajeExito("Agregada")
        this.router.navigate(["listadoMascotas"])
        this.loading = false
      },
      error => {
        console.log("no se proceso", error)
        this.loading = false
      }
    )
  }

  mensajeExito(mensaje: string) {
    this._snackBar.open(`La Mascota Fue ${mensaje} con Exito!`, "", {
      duration: 1500,
      horizontalPosition: "left"
    });
  }

}
