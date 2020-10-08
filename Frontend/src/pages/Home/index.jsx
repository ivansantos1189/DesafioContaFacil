import React, { useState, useEffect } from 'react';
import { toast } from 'react-toastify';
import { parseISO, format } from 'date-fns';

import Header from '../../components/Header';
import {
  ViewContainer,
  MainContainer,
  Card,
  CardTitle,
  CardButton,
  Button,
  ContentRigth,
  CashContent,
  CashContentSection,
  SummaryContainer,
  H2,
  H3,
  Input,
} from './styles';

import { getAccount, getListTransactions, deposit, payment, withdrawal } from '../../services/currentAccount';

export default function Home() {
  const [transactions, setTransactions] = useState([]);
  const [account, setAccount] = useState();
  const [amount, setAmount] = useState(0);

  async function loadAccount() {
    const { result, status, errors } = await getAccount();

    if (errors) throw "Error";

    if (status === "OK") {
      setAccount(result);
    }
  }

  async function loadTransactions() {
    const { result, status, errors } = await getListTransactions();

    if (errors) throw "Error"

    if (status === "OK") {
      setTransactions(result);
    }
  }

  useEffect(() => {
    async function loadData() {
      try {
        await loadAccount();
        await loadTransactions();
      }
      catch {
        toast.error("Ops! tivemos um problema tente novamente em alguns minutos");
      }
    }

    loadData();
  }, []);

  async function accountDeposit() {
    const { result, status, errors } = await deposit(amount);

    if (errors)
      return toast.error(errors[0]);
    if (status === "OK") {
      toast.success("Deposito efetuado com sucesso!");
      await loadAccount();
      await loadTransactions();
    }
  }

  async function accountPayment() {
    const { result, status, errors } = await payment(amount);

    if (errors)
      return toast.error(errors[0]);
    if (status === "OK") {
      toast.success("Pagamento efetuado com sucesso!");
      await loadAccount();
      await loadTransactions();
    }
  }

  async function accountWithdrawal() {
    const { result, status, errors } = await withdrawal(amount);

    if (errors)
      return toast.error(errors[0]);
    if (status === "OK") {
      toast.success("Retirada efetuado com sucesso!");
      await loadAccount();
      await loadTransactions();
    }
  }

  return (
    <>
      <Header></Header>
      <ViewContainer>
        <MainContainer>
          <Card>
            <CardTitle>
              <H2>Conta Fácil</H2>
            </CardTitle>
            <label>Valor</label>
            <div style={{ backgroundColor: '#F5F6FA' }}>
              <Input type="numeric" value={amount} onChange={e => setAmount(e.target.value)} />
            </div>
            <CardButton>
              <Button onClick={accountDeposit}>Depósito</Button>
              <Button onClick={accountPayment}>Retirada</Button>
              <Button onClick={accountPayment}>Pagamento</Button>
            </CardButton>
          </Card>
        </MainContainer>
        <ContentRigth>
          <CashContent>
            <CashContentSection>
              <H3>Resumo</H3>
              <SummaryContainer>
                <span>{account ? account.currentBalance.toLocaleString('pt-br', { style: 'currency', currency: 'BRL' }) : 'R$ 0,00'} </span>
              </SummaryContainer>
            </CashContentSection>
            <CashContentSection>
              <H3>Últimas Movimentações</H3>
              <SummaryContainer>
                {
                  transactions.map(item => (
                    <div>
                      <span>{`${getTypeTransaction(item.transactionType)} -
                              ${item.amount.toLocaleString('pt-br', { style: 'currency', currency: 'BRL' })} -
                              ${format(parseISO(item.transactionDate), 'dd/MM/yyyy HH:mm:ss',)}`}
                      </span>
                    </div>))
                }
              </SummaryContainer>
            </CashContentSection>
            <CashContentSection>
              <H3>Deposite na sua conta</H3>
            </CashContentSection>
          </CashContent>
        </ContentRigth>
      </ViewContainer >
      { JSON.stringify(transactions)}
    </>
  );
}

function getTypeTransaction(type) {
  const types = ['Rendimento', 'Deposito', 'Retirada', 'Pagaento'];

  return types[type];
}
