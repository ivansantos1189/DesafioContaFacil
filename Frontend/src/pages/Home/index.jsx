import React, { useState, useEffect } from 'react';
import Header from '../../components/Header';
import { ViewContainer, MainContainer, Card, CardTitle, H2 } from './styles';
import { getListTransactions } from '../../services/currentAccount';

export default function Home() {
  const [transactions, setTransactions] = useState([]);

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
    </>
  );
}
