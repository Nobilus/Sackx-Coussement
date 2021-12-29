import { FunctionComponent } from "react";
import { AuthProvider } from "./AuthProvider";
import { FilterProvider } from "./FilterProvider";

const AppProvider: FunctionComponent = ({ children }) => {
  return (
    <>
      <AuthProvider>
        <FilterProvider>{children}</FilterProvider>
      </AuthProvider>
    </>
  );
};

export default AppProvider;
