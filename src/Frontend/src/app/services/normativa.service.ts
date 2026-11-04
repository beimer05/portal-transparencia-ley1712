import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Normativa } from '../models/normativa.model';

@Injectable({
  providedIn: 'root'
})
export class NormativaService {
  private http = inject(HttpClient);
  private apiUrl = 'http://localhost:5219/api/normativa';

  getNormativas(): Observable<Normativa[]> {
    return this.http.get<Normativa[]>(this.apiUrl);
  }
}