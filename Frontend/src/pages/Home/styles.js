import styled from 'styled-components';

export const ViewContainer = styled.div`
  width: 100%;
  max-width: 1200px;
  margin: 0 auto;
  position: relative;
  top: 64px;
  --primary: var(--cash-primary);
  --over-primary: var(--cash-over-primary);
`
export const MainContainer = styled.div`
  height: calc(100vh - 64px);
  width: 800px;
  position: fixed;
  overflow: hidden;
  padding: 48px;
  background: var(--element-elevation);
`
export const Card = styled.div`
  height: 100%;
`
export const CardTitle = styled.div`
    color: var(--primary);
    margin-bottom: 24px;
`
export const H2 = styled.h2`
    font-size: 36px;
    font-weight: 700;
    font-family: 'Montserrat', sans-serif;
    letter-spacing: -1px;
    line-height: 44px;
`
