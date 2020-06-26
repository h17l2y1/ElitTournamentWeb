import { NgxLoggerLevel } from 'ngx-logger';

export const environment = {
  production: false,
  logLevel: NgxLoggerLevel.TRACE,
  serverLogLevel: NgxLoggerLevel.OFF,
  apiUrl: 'https://localhost:5001/api/',
};
