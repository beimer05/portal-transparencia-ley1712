import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PqrsdfRequest, PqrsdfResponse } from '../models/pqrsdf.model';

@Injectable({
  providedIn: 'root'
})
export class PqrsdfService {
  private http = inject(HttpClient);
  private apiUrl = 'http://localhost:5219/api/pqrsdf'; // Ajustar según el puerto de tu WebAPI

  radicarPqrsdf(request: PqrsdfRequest): Observable<PqrsdfResponse> {
    return this.http.post<PqrsdfResponse>(this.apiUrl, request);
  }

  consultarRadicado(radicado: string): Observable<PqrsdfResponse> {
    return this.http.get<PqrsdfResponse>(`${this.apiUrl}/${radicado}`);
  }
}