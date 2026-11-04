import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { ContratacionComponent } from './pages/contratacion/contratacion.component';
import { PresupuestoComponent } from './pages/presupuesto/presupuesto.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  // Aquí agregaremos las demás rutas conforme avancemos (normativa, contratación, etc.)
  { path: 'contratacion', component: ContratacionComponent },
  { path: 'presupuesto', component: PresupuestoComponent },
  { path: '**', redirectTo: '' }
];
