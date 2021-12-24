import { FunctionComponent } from "react";

const Table: FunctionComponent = ({ children }) => {
  return <section className="container mx-auto mb-8">{children}</section>;
};

export default Table;
