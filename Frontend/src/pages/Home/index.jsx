import React from 'react';
import Header from '../../components/Header';
import { ViewContainer, MainContainer, Card, CardTitle, H2 } from './styles';

export default function Home() {
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
