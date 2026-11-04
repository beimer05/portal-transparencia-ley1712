import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Presupuesto } from '../models/presupuesto.model';

@Injectable({
  providedIn: 'root'
})
export class PresupuestoService {
  private http = inject(HttpClient);
  private apiUrl = 'http://localhost:5219/api/presupuesto'; // Ajusta el puerto si tu API usa otro

  getPresupuestos(): Observable<Presupuesto[]> {
    return this.http.get<Presupuesto[]>(this.apiUrl);
  }
}
