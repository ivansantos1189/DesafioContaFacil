import React from 'react';
import ReactDOM from 'react-dom';
import { ToastContainer } from 'react-toastify';
import { AuthProvider } from './contexts/auth';

import App from './App';
import { GlobalStyle } from './styles';
import 'react-toastify/dist/ReactToastify.css';


ReactDOM.render(
  <React.StrictMode>
    <AuthProvider>
      <App />
    </AuthProvider>
    <GlobalStyle />
    <ToastContainer />
  </React.StrictMode>,
  document.getElementById('root'),
);
