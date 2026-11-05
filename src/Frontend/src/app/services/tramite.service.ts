import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tramite } from '../models/tramite.model';

@Injectable({
  providedIn: 'root'
})
export class TramiteService {
  private http = inject(HttpClient);
  private apiUrl = 'http://localhost:5219/api/tramite'; // Ajusta el puerto según tu entorno

  getTramites(): Observable<Tramite[]> {
    return this.http.get<Tramite[]>(this.apiUrl);
  }
}
