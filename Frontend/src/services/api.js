import axios from 'axios';

export const apiAuth = axios.create({
  baseURL: 'https://localhost:44333/api/',
});

export const apiApp = axios.create({
  baseURL: 'https',
});
