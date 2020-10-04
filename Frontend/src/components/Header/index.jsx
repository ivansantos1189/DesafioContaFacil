import React from 'react';

import { NavBarContainer, NavBar } from './styles';

export default function Header() {
  return (
    <NavBarContainer>
      <NavBar>
        <div style={{ whiteSpace: 'nowrap', justifyContent: 'center', alignItems: 'center', display: 'flex' }}></div>
        <span
          style={{
            display: 'flex', background: '#2e2d33', color: '#f5f6fa', width: '32px', height: '32px', alignItems: 'center',
            justifyContent: 'center',
            borderRadius: '16px',
            textAlign: 'center'
          }}
        ><span style={{
          fontSize: '20px',
          width: '32px',
          height: '32px',
          alignItems: 'center',
          justifyContent: 'center'
        }}>I</span></span>
      </NavBar>
    </NavBarContainer >
  )
}
