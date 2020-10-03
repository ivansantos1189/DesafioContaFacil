import styled from 'styled-components';

export const ContainerColumns = styled.div`
  grid-template-columns: 1fr 1fr;
  display: grid;
  grid-template-rows: 1fr;
  width: 100vw;
  height: 100vh;
  --primary: var(--account-primary);
  --over-primary: var(--account-over-primary);
`;

export const ContainerLeft = styled.div`
  display: flex;
  flex: 1;
  background-color: var(--primary);
  justify-content: center;
  align-items: center;
`;

export const ContainerRigth = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: var(--element-elevation);
  max-width: 860px;
  flex-grow: 1;
`;

export const Main = styled.div`
  display: flex;
  flex-grow: 1;
  flex-direction: column;
  justify-content: center;
  width: 100%;
  max-width: 360px;
`;

export const Form = styled.form`
  padding-bottom: 24px;
  margin-top: 0em;
`;

export const H3 = styled.h3`
  margin: 0px;
  font-size: 24px;
  font-weight: 700;
  font-family: 'Montserrat', sans-serif;
  letter-spacing: -1px;
  line-height: 32px;
`;

export const Fieldset = styled.fieldset`
  padding: 0;
  margin: 0;
  border: 0;
  min-height: 110px;
  padding: 24px 0;
`;

export const Label = styled.label`
  font-size: 16px;
  font-weight: 400;
  font-family: 'Source Sans Pro', sans-serif;
  letter-spacing: 0px;
  line-height: 24px;
`;

export const WrapperInput = styled.div`
  margin-top: 4px;
  margin-bottom: 8px;
  display: table;
  position: relative;
  border-collapse: separate;
  width: 100%;
  border-radius: 4px;
  background-color: var(--element-background);
`;

export const InputAddon = styled.div`
  font-family: 'Source Sans Pro', Helvetica, Arial, Sans-Serif;
  color: #2e2d33;
  font-size: 1.25rem;
  line-height: 1.5rem;
  letter-spacing: 0;
  font-weight: 400;
  transition: 0.2s cubic-bezier(0.55, 0, 0.1, 1);
  margin-top: 0;
  margin-bottom: 0;
  width: 1%;
  white-space: nowrap;
  vertical-align: middle;
  padding: 0 15px;
  display: table-cell;
  border: 1px solid transparent;
`;

export const Input = styled.input`
  padding: 15px;
  font-family: 'Source Sans Pro', Helvetica, Arial, Sans-Serif;
  color: #2e2d33;
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

export const Button = styled.button`
  outline: none;
  max-height: 72px;
  color: var(--text-negative);
  background-color: ${(props) => (props.disabled ? 'var(--text-disabled)' : 'var(--status-positive)')};
  user-select: none;
  padding: 24px 32px;
  min-width: 131px;
  min-height: 72px;
  font-size: 18px;
  font-weight: 700;
  font-family: Source Sans Pro, sans-serif;
  letter-spacing: 0;
  line-height: 24px;
  text-transform: uppercase;
  cursor: ${(props) => (props.disabled ? 'default' : 'pointer')};
  border: none;
  border-radius: 100px;
  transition: 0.2s cubic-bezier(0.55, 0, 0.1, 1);
  width: 100%;
  :hover {
    transform: ${(props) => (props.disabled ? '' : 'scale(1.05)')};
  }
`;

export const A = styled.a`
  font-size: 14px;
  font-weight: 700;
  font-family: 'Source Sans Pro', sans-serif;
  letter-spacing: 0px;
  line-height: 18px;
  text-transform: uppercase;
  cursor: pointer;
`
