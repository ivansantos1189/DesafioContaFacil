import { apiAuth } from './api';

export async function signIn(email, password) {
  try {
    return await apiAuth.post('auth/login', { Email: email, Password: password });
  } catch { }
}

export async function signUp(email, password) {
  try {
    return await apiAuth.post('auth/signup', { Email: email, Password: password });
  } catch { }
}
