import { FunctionComponent } from "react";

const TableRow: FunctionComponent = ({ children }) => {
  return <div className="grid grid-cols-5 mx-2 mb-4">{children}</div>;
};

export default TableRow;
