import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'SalesManagement2023',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44365/',
    redirectUri: baseUrl,
    clientId: 'SalesManagement2023_App',
    responseType: 'code',
    scope: 'offline_access SalesManagement2023',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44365',
      rootNamespace: 'DMS.SalesManagement2023',
    },
  },
} as Environment;
