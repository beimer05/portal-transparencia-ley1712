import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { ContratacionComponent } from './pages/contratacion/contratacion.component';
import { PresupuestoComponent } from './pages/presupuesto/presupuesto.component';
import { NormativaComponent } from './pages/normativa/normativa.component';
import { FuncionariosComponent } from './pages/funcionario/funcionario.component';
import { TramiteComponent } from './pages/tramite/tramite.component';
import { PqrsdfComponent } from './pages/pqrsdf/pqrsdf.component'; 

export const routes: Routes = [
  { path: '', component: HomeComponent },
  // Aquí agregaremos las demás rutas conforme avancemos (normativa, contratación, etc.)
  { path: 'contratacion', component: ContratacionComponent },
  { path: 'presupuesto', component: PresupuestoComponent },
  { path: 'normativa', component: NormativaComponent },
  { path: 'funcionarios', component: FuncionariosComponent },
  { path: 'tramites', component: TramiteComponent },
  { path: 'pqrsdf', component: PqrsdfComponent }, // <--- Registrar la ruta
  { path: '**', redirectTo: '' }
];
