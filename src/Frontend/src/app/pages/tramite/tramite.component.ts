import { Component, OnInit, inject, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TramiteService } from '../../services/tramite.service';
import { Tramite } from '../../models/tramite.model';

@Component({
  selector: 'app-tramite',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './tramite.component.html',
  styleUrl: './tramite.component.scss'
})
export class TramiteComponent implements OnInit {
  private tramiteService = inject(TramiteService);

  tramites = signal<Tramite[]>([]);
  loading = signal<boolean>(true);

  ngOnInit(): void {
    this.tramiteService.getTramites().subscribe({
      next: (data) => {
        this.tramites.set(data);
        this.loading.set(false);
      },
      error: (err) => {
        console.error('Error al cargar trámites y servicios', err);
        this.loading.set(false);
      }
    });
  }
}
