import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
// import { environment } from 'src/environments/environment';
import { environment } from 'src/environments/environment.development';
import { Mascota } from '../Interfaces/mascota';

@Injectable({
  providedIn: 'root'
})
export class MascotaService {

  myAppUrl: string = environment.endpoint;
  myApiUrl: string = "api/Mascota/"

  constructor(private http: HttpClient) { }

  getMascotas(): Observable<Mascota[]> {
    return this.http.get<Mascota[]>(`${this.myAppUrl}${this.myApiUrl}`)
  }

  getMascota(id: number): Observable<Mascota> {
    return this.http.get<Mascota>(`${this.myAppUrl}${this.myApiUrl}${id}`)
  }

  deleteMascota(id: number): Observable<void> {
    return this.http.delete<void>(`${this.myAppUrl}${this.myApiUrl}${id}`)
  }

  addMascota(mascota: Mascota): Observable<Mascota> {
    return this.http.post<Mascota>(`${this.myAppUrl}${this.myApiUrl}`, mascota)
  }
}
