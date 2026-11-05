export interface PqrsdfRequest {
  tipoSolicitud: string; // Petición, Queja, Reclamo, Sugerencia, Denuncia, Felicitación
  nombreSolicitante: string;
  email: string;
  telefono: string;
  asunto: string;
  descripcion: string;
}

export interface PqrsdfResponse {
  radicado: string;
  fechaRadicacion: string;
  mensaje: string;
  estado: string;
}
