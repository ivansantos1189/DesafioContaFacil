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

export const CardButton = styled.div`
  display: flex;
  align-items: center;
`

export const Button = styled.button`
    font-size: 18px;
    font-weight: 700;
    font-family: Source Sans Pro,sans-serif;
    letter-spacing: 0;
    line-height: 24px;
    text-transform: uppercase;
    cursor: pointer;
    background-color: var(--primary);
    color: var(--over-primary);
    border: none;
    padding: 8px 24px;
    min-width: 115px;
    min-height: 40px;
    border-radius: 100px;
    -webkit-transition: .2s cubic-bezier(.55,0,.1,1);
    transition: .2s cubic-bezier(.55,0,.1,1);
    margin-right: 12px;
    :hover {
    transform: scale(1.05);
  }
`;

export const ContentRigth = styled.div`
  padding: 48px;
  min-height: calc(100vh - 64px);
  margin-left: 800px;
  width: 100%;
  max-width: 400px;
  position: absolute;
  background: var(--element-elevation);
  border-left: 1px solid var(--element-divider);
`;

export const CashContent = styled.div`
  width: 100%;
  background: var(--element-elevation);
`;

export const CashContentSection = styled.div`
  padding-bottom: 48px;
`;

export const SummaryContainer = styled.div`
  display: block;
`;

export const H2 = styled.h2`
  font-size: 36px;
  font-weight: 700;
  font-family: 'Montserrat', sans-serif;
  letter-spacing: -1px;
  line-height: 44px;
`
export const H3 = styled.h3`
  font-size: 24px;
  font-weight: 700;
  font-family: 'Montserrat', sans-serif;
  letter-spacing: -1px;
  line-height: 32px;
  color: var(--text-primary);
  padding-bottom: 8px;
  margin: 0px;
`;

export const Input = styled.input`
  padding: 15px;
  font-family: 'Source Sans Pro', Helvetica, Arial, Sans-Serif;
  color: #2e2d33;
  background-color: var(--text-primary);
  font-size: 1.25rem;
  line-height: 1.5rem;
  letter-spacing: 0;
  font-weight: 400;
  transition: 0.2s cubic-bezier(0.55, 0, 0.1, 1);
  margin-top: 0;
  margin-bottom: 0;
  padding-left: 0 !important;
  padding-right: 0 !important;
  width: 100%;
  background-color: transparent;
  border: 1px solid transparent;
`;

