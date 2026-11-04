export interface Normativa {
  id: number;
  tipoNorma: string;
  numeroNorma: string;
  anio: number;
  descripcion: string;
  enlaceDocumento: string;
  // Propiedades auxiliares para la vista del Home
  fechaPublicacion: string;
  titulo: string;
}
