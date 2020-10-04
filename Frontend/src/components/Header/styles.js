import styled from 'styled-components';

export const NavBarContainer = styled.div`
  background: #f5f6fa !important;
  border-bottom: 1px solid #ebecf3;
  height: 64px;
  width: 100%;
  z-index: 15;
  top: 0;
  position: fixed;
  display: flex;
  padding-top: 0;
`

export const NavBar = styled.div`
  display: flex;
  justify-content: space-between;
  width: 100%;
  height: 100%;
  margin: 0 auto;
  padding: 0 24px;
  font-size: 14px;
  font-weight: 700;
  letter-spacing: 0.875;
  align-items: center;
  text-transform: uppercase;
`
