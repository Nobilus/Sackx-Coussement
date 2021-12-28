import react, { useEffect } from "react";

import { createContext, FunctionComponent, useContext, useState } from "react";
import { createLogicalWrapper } from "src/utils/logicalWrapper";

interface IAuthContext {
  signedIn: boolean;
  user: any;
  signOut: () => void;
  signIn: () => void;
}

const AuthContext = createContext<IAuthContext>({} as IAuthContext);

export function useAuth() {
  return useContext(AuthContext);
}

export const Authenticated = createLogicalWrapper(
  AuthContext,
  (ctx: any) => ctx.signedIn
);

export const NotAuthenticated = createLogicalWrapper(
  AuthContext,
  (ctx: any) => !ctx.signedIn
);

export const AuthProvider: FunctionComponent = ({ children }) => {
  const [signedIn, setSignedIn] = useState(true);
  const [user, setUser] = useState<any | null>(null);

  const signOut = () => {};

  const signIn = () => {
    setSignedIn(true);
  };

  const value = {
    signedIn,
    user,
    signOut,
    signIn,
  };

  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};
