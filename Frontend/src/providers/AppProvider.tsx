import { FunctionComponent } from "react";
import { AuthProvider } from "./AuthProvider";
import DataProvider from "./DataProvider";
import { FilterProvider } from "./FilterProvider";

const AppProvider: FunctionComponent = ({ children }) => {
  return (
    <>
      <AuthProvider>
        <DataProvider>
          <FilterProvider>{children}</FilterProvider>
        </DataProvider>
      </AuthProvider>
    </>
  );
};

export default AppProvider;
