import { Component , inject, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { PqrsdfService } from '../../services/pqrsdf.service';
import { PqrsdfRequest, PqrsdfResponse } from '../../models/pqrsdf.model';

@Component({
  selector: 'app-pqrsdf',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './pqrsdf.component.html',
  styleUrl: './pqrsdf.component.scss'
})
export class PqrsdfComponent {
  private pqrsdfService = inject(PqrsdfService);

  // Formulario y Estados con Signals
  tipoSolicitud = signal<string>('Peticion');
  nombreSolicitante = signal<string>('');
  email = signal<string>('');
  telefono = signal<string>('');
  asunto = signal<string>('');
  descripcion = signal<string>('');

  loading = signal<boolean>(false);
  respuestaRadicado = signal<PqrsdfResponse | null>(null);
  errorMensaje = signal<string | null>(null);

  // Consulta de Radicado
  numRadicadoConsulta = signal<string>('');
  resultadoConsulta = signal<PqrsdfResponse | null>(null);

  radicar(): void {
    if (!this.nombreSolicitante() || !this.email() || !this.asunto() || !this.descripcion()) {
      this.errorMensaje.set('Por favor completa todos los campos obligatorios (*).');
      return;
    }

    this.loading.set(true);
    this.errorMensaje.set(null);

    const payload: PqrsdfRequest = {
      tipoSolicitud: this.tipoSolicitud(),
      nombreSolicitante: this.nombreSolicitante(),
      email: this.email(),
      telefono: this.telefono(),
      asunto: this.asunto(),
      descripcion: this.descripcion()
    };

    this.pqrsdfService.radicarPqrsdf(payload).subscribe({
      next: (res) => {
        this.respuestaRadicado.set(res);
        this.loading.set(false);
        this.limpiarFormulario();
      },
      error: (err) => {
        console.error('Error al radicar PQRSDF', err);
        this.errorMensaje.set('Ocurrió un error al procesar la solicitud. Intenta de nuevo.');
        this.loading.set(false);
      }
    });
  }

  consultar(): void {
    if (!this.numRadicadoConsulta()) return;

    this.loading.set(true);
    this.pqrsdfService.consultarRadicado(this.numRadicadoConsulta()).subscribe({
      next: (res) => {
        this.resultadoConsulta.set(res);
        this.loading.set(false);
      },
      error: () => {
        this.resultadoConsulta.set(null);
        this.errorMensaje.set('No se encontró información para el número de radicado ingresado.');
        this.loading.set(false);
      }
    });
  }

  private limpiarFormulario(): void {
    this.nombreSolicitante.set('');
    this.email.set('');
    this.telefono.set('');
    this.asunto.set('');
    this.descripcion.set('');
  }
}