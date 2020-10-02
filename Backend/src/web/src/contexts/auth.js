import React, { createContext, useState, useEffect, useContext } from "react";
import config from "react-native-config";

import AsyncStorage from "@react-native-community/async-storage";

import * as auth from "../services/auth";

const AuthContext = createContext({ signed: false, user: {}, loading: true });

export const AuthProvider = ({ children }) => {
  const [user, setUser] = useState(null);
  const [token, setToken] = useState(null);
  const [loading, setLoading] = useState(true);
  const [signed, setSigned] = useState(false);

  useEffect(() => {
    async function loadStorageData() {
      await AsyncStorage.removeItem("@RNAuth:token");

      if (config.NEED_AUTHENTICATION === "false") {
        await signIn("Ivanzin");
      }

      const storageUser = await AsyncStorage.getItem("@RNAuth:user");

      setUser(JSON.parse(storageUser));
      setLoading(false);
    }

    loadStorageData();
  }, []);

  async function signIn(code) {
    const response = await auth.signIn(code);
    await AsyncStorage.setItem("@RNAuth:user", JSON.stringify(response.User));
    await AsyncStorage.setItem("@RNAuth:token", response.Token);
    setUser(response.User);
    setToken(response.Token);
    setSigned(true);
  }

  async function signOut() {
    setSigned(false);
    setUser(null);
    await AsyncStorage.multiRemove(["@RNAuth:user", "@RNAuth:token"]);
  }

  return (
    <AuthContext.Provider
      value={{
        signed,
        user,
        signIn,
        signOut,
        loading,
        token,
      }}
    >
      {children}
    </AuthContext.Provider>
  );
};

export function useAuth() {
  const context = useContext(AuthContext);

  return context;
}
