import { createContext, FunctionComponent, useContext, useState } from "react";
import { createLogicalWrapper } from "../utils/logicalWrapper";

interface IAuthContext {
  signedIn: boolean;
  user: any;
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
  const [signedIn, setSignedIn] = useState(false);
  const [user, setUser] = useState<any | null>(null);

  const signOut = () => {};

  const signIn = () => {};

  const value = {
    signedIn,
    user,
    signOut,
    signIn,
  };

  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};
