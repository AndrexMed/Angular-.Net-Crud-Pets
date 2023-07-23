import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Mascota } from 'src/app/Interfaces/mascota';
import { MascotaService } from 'src/app/Services/mascota.service';


// const listaMascotas: Mascota[] = [
//   { nombre: "Morgan", edad: 13, raza: "PitBull", color: "Blanco", peso: 30 },
//   { nombre: "Niky", edad: 1, raza: "PitBull", color: "Negra", peso: 30 },
//   { nombre: "Lester", edad: 5, raza: "PitBull", color: "Cafe", peso: 30 },
//   { nombre: "Rocky", edad: 16, raza: "Frespuder", color: "Blanco", peso: 30 },
//   { nombre: "Barbas", edad: 17, raza: "PitBull", color: "Blanco", peso: 30 },
//   { nombre: "Tony", edad: 3, raza: "PitBull", color: "Blanco", peso: 30 },
//   { nombre: "Max", edad: 7, raza: "PitBull", color: "Blanco", peso: 30 },
//   { nombre: "Firulais", edad: 8, raza: "PitBull", color: "Blanco", peso: 30 },
//   { nombre: "Zafiro", edad: 9, raza: "PitBull", color: "Blanco", peso: 30 },
//   { nombre: "Zeus", edad: 13, raza: "PitBull", color: "Blanco", peso: 30 }
// ];

@Component({
  selector: 'app-listado-mascotas',
  templateUrl: './listado-mascotas.component.html',
  styleUrls: ['./listado-mascotas.component.css']
})
export class ListadoMascotasComponent implements OnInit, AfterViewInit {


  displayedColumns: string[] = ['id', 'nombre', 'edad', 'raza', 'color', 'peso', 'acciones'];
  dataSource = new MatTableDataSource<Mascota>();

  loading: boolean = false;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _snackBar: MatSnackBar,
    private _mascotaService: MascotaService) { }

  ngOnInit(): void {
    this.obtenerMascotas()
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;

    //this.paginator._intl.itemsPerPageLabel = "Items por pagina"
     if (this.dataSource.data.length > 0) {
       this.paginator._intl.itemsPerPageLabel = "Items por pagina"
     }
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  obtenerMascotas() {
    this.loading = true

    this._mascotaService.getMascotas().subscribe(
      response => {

        this.loading = false

        this.dataSource.data = response
      },
      error => {
        this.loading = false
        alert("Oops ocurrio un error en el servidor!")
        console.log("Error en el servidor al obtener las mascotas!", error)
      }
    );
  }
  // obtenerMascotas() {
  //   this.loading = true

  //   this._mascotaService.getMascotas().subscribe({
  //     next: (response) => {

  //       this.loading = false

  //       this.dataSource.data = response
  //     },
  //     error: (e) => {
  //       this.loading = false
  //       alert("Oops ocurrio un error en el servidor!")
  //       console.log("Error en el servidor al obtener las mascotas!", e)
  //     },
  //     complete: () => console.log("Transaction Complete!")
  //   })
  // }

  eliminarMascota(id: number) {
    this.loading = true

    this._mascotaService.deleteMascota(id).subscribe( () => {
      this.loading = false 
      this.mensajeExito()
      this.obtenerMascotas()
    })

    // setTimeout(() => {
    //   this.loading = false
    //   this._snackBar.open("La Mascota Fue Eliminada con Exito!", "", {
    //     duration: 1500,
    //     horizontalPosition: "right"
    //   });
    // }, 3000);
  }

  mensajeExito() {
    this._snackBar.open("La Mascota Fue Eliminada con Exito!", "", {
      duration: 1500,
      horizontalPosition: "right"
    });
  }

}
