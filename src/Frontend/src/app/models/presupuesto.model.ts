export interface Presupuesto {
  id: number;
  codigoRubro: string;
  descripcionConcepto: string;
  valorAprobado: number;
  valorEjecutado: number;
  vigenciaFiscal: number;
}