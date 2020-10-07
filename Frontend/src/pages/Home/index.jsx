import React, { useState, useEffect } from 'react';
import Header from '../../components/Header';
import { ViewContainer, MainContainer, Card, CardTitle, H2 } from './styles';
import { getListTransactions } from '../../services/currentAccount';

export default function Home() {
  const [transactions, setTransactions] = useState([]);

  useEffect(() => {
    async function loadData() {

      const { result, status, errors } = await getListTransactions();

      if (errors) return setError(errors[0]);

      if (status === "OK") {
        setTransactions(result);
      }

    }

    loadData();
  }, []);

  return (
    <>
      <Header></Header>
      <ViewContainer>
        <MainContainer>
          <Card>
            <CardTitle>
              <H2>Conta</H2>
            </CardTitle>
          </Card>
        </MainContainer>
      </ViewContainer>
      {JSON.stringify(transactions)}
    </>
  );
}
