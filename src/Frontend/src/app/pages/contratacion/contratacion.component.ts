import { Component, OnInit, inject, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContratacionService } from '../../services/contratacion.service';
import { Contrato } from '../../models/contrato.model';

@Component({
  selector: 'app-contratacion',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './contratacion.component.html',
  styleUrl: './contratacion.component.scss'
})
export class ContratacionComponent implements OnInit {
  private contratacionService = inject(ContratacionService);

  contratos = signal<Contrato[]>([]);
  cargando = signal<boolean>(true);

  ngOnInit(): void {
    this.contratacionService.getContratos().subscribe({
      next: (data) => {
        this.contratos.set(data);
        this.cargando.set(false);
      },
      error: (err) => {
        console.error('Error al cargar contratos:', err);
        this.cargando.set(false);
      }
    });
  }
}