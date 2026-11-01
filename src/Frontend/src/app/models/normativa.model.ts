export interface Normativa {
  id: number;
  titulo: string;
  descripcion: string;
  tipo: string; // Ej: 'Ley', 'Decreto', 'Resolución'
  numero: string;
  fechaPublicacion: string;
  urlDocumento: string;
}
