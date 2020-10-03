import React from 'react';
import { ViewContainer, MainContainer, Card, CardTitle, H2 } from './styles';

export default function Home() {
  return (
    <ViewContainer>
      <MainContainer>
        <Card>
          <CardTitle>
            <H2>Conta</H2>
          </CardTitle>
        </Card>
      </MainContainer>
    </ViewContainer>
  );
}
