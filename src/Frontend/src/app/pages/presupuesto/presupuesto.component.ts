import { Component, OnInit, signal, inject } from '@angular/core';
import { CommonModule, CurrencyPipe } from '@angular/common';
import { PresupuestoService } from '../../services/presupuesto.service';
import { Presupuesto } from '../../models/presupuesto.model';

@Component({
  selector: 'app-presupuesto',
  standalone: true,
  imports: [CommonModule, CurrencyPipe],
  templateUrl: './presupuesto.component.html',
  styleUrl: './presupuesto.component.scss'
})
export class PresupuestoComponent implements OnInit {
  private presupuestoService = inject(PresupuestoService);

  presupuestos = signal<Presupuesto[]>([]);
  cargando = signal<boolean>(true);

  ngOnInit(): void {
    this.presupuestoService.getPresupuestos().subscribe({
      next: (data) => {
        this.presupuestos.set(data);
        this.cargando.set(false);
      },
      error: (err) => {
        console.error('Error al cargar el presupuesto:', err);
        this.cargando.set(false);
      }
    });
  }
}