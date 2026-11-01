import { Component, OnInit, inject,signal} from '@angular/core';
import { CommonModule } from '@angular/common';
import { TransparenciaService } from '../../services/transparencia.service';
import { Normativa } from '../../models/normativa.model';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
private transparenciaService = inject(TransparenciaService);

  // Usamos señales para almacenar las normativas y el estado de carga
  normativas = signal<Normativa[]>([]);
  cargando = signal<boolean>(true);

  ngOnInit(): void {
    this.obtenerNormativas();
  }

  obtenerNormativas() {
    this.transparenciaService.getNormativas().subscribe({
      next: (data) => {
        this.normativas.set(data);
        this.cargando.set(false);
      },
      error: (err) => {
        console.error('Error al conectar con la WebAPI:', err);
        this.cargando.set(false);
      }
    });
  }
}
