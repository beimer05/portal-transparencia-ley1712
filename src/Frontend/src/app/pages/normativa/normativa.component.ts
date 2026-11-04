import { Component, OnInit, signal, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NormativaService } from '../../services/normativa.service';
import { Normativa } from '../../models/normativa.model';

@Component({
  selector: 'app-normativa',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './normativa.component.html',
  styleUrl: './normativa.component.scss'
})
export class NormativaComponent implements OnInit {
  private normativaService = inject(NormativaService);

  normativas = signal<Normativa[]>([]);
  cargando = signal<boolean>(true);

  ngOnInit(): void {
    this.normativaService.getNormativas().subscribe({
      next: (data) => {
        this.normativas.set(data);
        this.cargando.set(false);
      },
      error: (err) => {
        console.error('Error al cargar la normativa:', err);
        this.cargando.set(false);
      }
    });
  }
}