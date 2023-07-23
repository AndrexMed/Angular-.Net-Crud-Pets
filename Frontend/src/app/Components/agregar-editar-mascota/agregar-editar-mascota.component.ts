import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { Mascota } from 'src/app/Interfaces/mascota';
import { MascotaService } from 'src/app/Services/mascota.service';

@Component({
  selector: 'app-agregar-editar-mascota',
  templateUrl: './agregar-editar-mascota.component.html',
  styleUrls: ['./agregar-editar-mascota.component.css']
})
export class AgregarEditarMascotaComponent {

  loading: boolean = false

  formulario: FormGroup

  constructor(private formu: FormBuilder,
    private _mascotaService: MascotaService,
    private _snackBar: MatSnackBar,
    private router: Router) {
    this.formulario = this.formu.group({
      nombre: ["", Validators.required],
      raza: ["", Validators.required],
      color: ["", Validators.required],
      edad: ["", Validators.required],
      peso: ["", Validators.required]
    })
  }

  agregarMascota() {
    // const nombre = this.formulario.value.nombre
    // const nombre2 = this.formulario.get("nombre")?.value
    // console.log(nombre + "\n" + nombre2)
    const mascota: Mascota = {
      nombre: this.formulario.value.nombre,
      raza: this.formulario.value.raza,
      color: this.formulario.value.color,
      edad: this.formulario.value.edad,
      peso: this.formulario.value.peso,
    }


    //Enviamos los datos al back
    this._mascotaService.addMascota(mascota).subscribe(
      response => {
        console.log(response)
        this.mensajeExito()
        this.router.navigate(["listadoMascotas"])
      },
      error => {
        alert("Ocurrio un erro el agregar la mascota!")
      }
    )
  }

  mensajeExito() {
    this._snackBar.open("La Mascota Fue Agregada con Exito!", "", {
      duration: 1500,
      horizontalPosition: "left"
    });
  }

}
