import { FunctionComponent } from "react";
import { AuthProvider } from "./AuthProvider";

const AppProvider: FunctionComponent = ({ children }) => {
  return (
    <>
      <AuthProvider>{children}</AuthProvider>
    </>
  );
};

export default AppProvider;
