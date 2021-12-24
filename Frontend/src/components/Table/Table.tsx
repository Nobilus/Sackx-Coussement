import { FunctionComponent } from "react";

const Table: FunctionComponent = ({ children }) => {
  return (
    <section className="container max-w-6xl mx-auto mb-8">{children}</section>
  );
};

export default Table;
