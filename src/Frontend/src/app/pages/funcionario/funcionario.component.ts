import { Component, OnInit, inject, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FuncionarioService } from '../../services/funcionario.service';
import { Funcionario } from '../../models/funcionario.model';

@Component({
  selector: 'app-funcionarios',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './funcionario.component.html',
   styleUrl: './funcionario.component.scss'
})
export class FuncionariosComponent implements OnInit {
  private funcionarioService = inject(FuncionarioService);

  funcionarios = signal<Funcionario[]>([]);
  loading = signal<boolean>(true);

  ngOnInit(): void {
    this.funcionarioService.getFuncionarios().subscribe({
      next: (data) => {
        this.funcionarios.set(data);
        this.loading.set(false);
      },
      error: (err) => {
        console.error('Error al cargar funcionarios', err);
        this.loading.set(false);
      }
    });
  }
}