import axios from 'axios';

export const apiAuth = axios.create({
  baseURL: 'https://localhost:44333/api/',
});

export const apiApp = axios.create({
  baseURL: 'https://localhost:44352/api/',
});

apiApp.interceptors.request.use(
  async (requestConfig) => {
    const userToken = JSON.parse(sessionStorage.userToken);
    requestConfig.headers.common.Authorization = `Bearer ${userToken.acessToken}`;
    return requestConfig;
  },
  (response) => Promise.reject(response),
);
