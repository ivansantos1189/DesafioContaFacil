import { apiAuth } from './api';

export async function signIn(email, password) {
  try {
    const result = await apiAuth.post('auth/login', { Email: email, Password: password });
    return result.data;
  } catch (e) { }
}

export async function signUp(email, password) {
  try {
    const result = await apiAuth.post('auth/signup', { Email: email, Password: password });
  } catch (e) { }
}
