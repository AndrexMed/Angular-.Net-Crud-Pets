import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';

//Componentes
import { AppComponent } from './app.component';
import { AgregarEditarMascotaComponent } from './Components/agregar-editar-mascota/agregar-editar-mascota.component';
import { ListadoMascotasComponent } from './Components/listado-mascotas/listado-mascotas.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { VerMascotaComponent } from './Components/ver-mascota/ver-mascota.component';

//Angular Material
import { SharedModule } from './shared/shared.module';

@NgModule({
  declarations: [
    AppComponent,
    AgregarEditarMascotaComponent,
    ListadoMascotasComponent,
    VerMascotaComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    SharedModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
