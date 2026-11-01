import { Injectable,inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Normativa } from '../models/normativa.model';

@Injectable({
  providedIn: 'root'
})
export class TransparenciaService {
// Inyección de dependencias moderna mediante inject()
  private http = inject(HttpClient);
  
  // URL base apuntando a la WebAPI de .NET 8 (ajustaremos el puerto más adelante)
  private apiUrl = 'http://localhost:5219/api/transparencia';

  // Obtener el listado de normativas de la Ley 1712
  getNormativas(): Observable<Normativa[]> {
    return this.http.get<Normativa[]>(`${this.apiUrl}/normativas`);
  }
}
