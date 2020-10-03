import React from 'react';

import {
  BrowserRouter as Router,
  Switch,
  Route,
  Redirect,
} from "react-router-dom";

import SignIn from './pages/SignIn';
import SignUp from './pages/SignUp';
import Home from './pages/Home';

import { useAuth } from './contexts/auth';


const Routes = () => {
  const { signed } = useAuth();

  return (
    <Router>
      <Switch>
        <Route path="/login">
          <SignIn />
        </Route>
        <Route path="/signup">
          <SignUp />
        </Route>
        <PrivateRoute signed={signed} path="/">
          <Home />
        </PrivateRoute>
      </Switch>
    </Router>
  );
}

function PrivateRoute({ children, signed, ...rest }) {
  return (
    <Route
      {...rest}
      render={({ location }) =>
        signed ? (
          children
        ) : (
            <Redirect
              to={{
                pathname: "/login",
                state: { from: location }
              }}
            />
          )
      }
    />
  );
}

export default Routes;
