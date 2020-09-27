import { createGlobalStyle } from 'styled-components';

const GlobalStyle = createGlobalStyle`
  :root {
    --warren-for-business-over-primary: #fff;
    --warren-for-business-primary: #7bc491;
    --trading-over-primary: #fff;
    --trading-primary: #007aff;
    --wealth-over-primary: #fff;
    --wealth-primary: #ff9500;
    --cash-over-primary: #fff;
    --cash-primary: #1bbc58;
    --account-over-primary: #fff;
    --account-primary: #ee2e5d;
    --benchmark-savings: #ee2e5d;
    --benchmark-cdi: #f5710c;
    --benchmark-ipca: #776df9;
    --benchmark-interest: #3599ff;
    --asset-multimarket: #f6678d;
    --asset-others: #ee2e5d;
    --asset-stocks: #ffb500;
    --asset-fixed-income: #006bd6;
    --status-info: #3599ff;
    --status-progress-bar-positive: #05f277;
    --status-negative: #e84423;
    --status-attention: #f5710c;
    --status-positive: #00b563;
    --feature-invites: #05f277;
    --feature-banking-account: #fff;
    --element-overlay: #2e2d33;
    --element-negative: #fff;
    --element-hover-over-color: #fff;
    --element-hover: #f2f3f7;
    --element-background: #f5f6fa;
    --element-elevation: #fff;
    --element-interactive-elevation: #e3e4eb;
    --element-divider: #ebecf3;
    --element-primary: #2e2d33;
    --element-secondary: #d1d1d9;
    --text-negative: #fff;
    --text-disabled: #c9cad4;
    --text-placeholder: #b0b1bd;
    --text-secondary: #8b8d99;
    --text-primary: #2e2d33;
    
  }
    
  * {
    outline: none;
  }
  html {
    scroll-behavior: smooth;
  }
  
  body {
    font-family: "Source Sans Pro", Helvetica, Arial, Sans-Serif, sans-serif;
    -webkit-font-smoothing: antialiased;
    color: var(--text-primary);
  }
`;

export default GlobalStyle;
