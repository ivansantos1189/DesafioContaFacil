import { apiAuth } from './api';

export async function signIn(email, password) {
  try {
    const result = await apiAuth.post('auth/login', { Email: email, Password: password });
    return result.data;
  } catch {
    return { status: 'Error', errors: ['Ocorreu um erro inesperado, tente novamente em alguns minutos ou contato o nosso suporte'], result: false }
  }
}

export async function signUp(email, password) {
  try {
    const result = await apiAuth.post('auth/signup', { Email: email, Password: password, ConfirmPassword: password });
    return result.data;
  } catch {
    return { status: 'Error', errors: ['Ocorreu um erro inesperado, tente novamente em alguns minutos ou contato o nosso suporte'], result: false }
  }
}
