import { apiApp } from './api';

export async function createAccount() {
  try {
    const result = await apiApp.post('currentaccount');
    return result.data;
  }
  catch {
    return { status: 'Error', errors: ['Ocorreu um erro inesperado, tente novamente em alguns minutos ou contato o nosso suporte'], result: false }
  }
}

export async function getAccount() {
  try {
    const result = await apiApp.get('currentaccount');
    return result.data;
  }
  catch {
    return { status: 'Error', errors: ['Ocorreu um erro inesperado, tente novamente em alguns minutos ou contato o nosso suporte'], result: false }
  }
}

export async function payment(amount) {
  try {
    const result = await apiApp.post('currentaccount/payment', { Amount: parseFloat(amount) });
    return result.data;
  }
  catch {
    return { status: 'Error', errors: ['Ocorreu um erro inesperado, tente novamente em alguns minutos ou contato o nosso suporte'], result: false }
  }
}

export async function deposit(amount) {
  try {
    const result = await apiApp.post('currentaccount/deposit', { Amount: parseFloat(amount) });
    return result.data;
  }
  catch {
    return { status: 'Error', errors: ['Ocorreu um erro inesperado, tente novamente em alguns minutos ou contato o nosso suporte'], result: false }
  }
}

export async function withdrawal(amount) {
  try {
    const result = await apiApp.post('withdrawal', { Amount: amount });
    return result.data;
  }
  catch {
    return { status: 'Error', errors: ['Ocorreu um erro inesperado, tente novamente em alguns minutos ou contato o nosso suporte'], result: false }
  }
}

export async function getListTransactions() {
  try {
    const result = await apiApp.get('currentaccount/transaction_list');
    return result.data;
  }
  catch {
    return { status: 'Error', errors: ['Ocorreu um erro inesperado, tente novamente em alguns minutos ou contato o nosso suporte'], result: false }
  }
}

