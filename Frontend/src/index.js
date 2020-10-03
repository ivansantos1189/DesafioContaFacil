import React from 'react';
import ReactDOM from 'react-dom';
import { AuthProvider } from './contexts/auth';

import App from './App';
import { GlobalStyle } from './styles';

ReactDOM.render(
  <React.StrictMode>
    <AuthProvider>
      <App />
    </AuthProvider>
    <GlobalStyle />
  </React.StrictMode>,
  document.getElementById('root'),
);
