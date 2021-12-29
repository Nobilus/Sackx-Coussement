import { FunctionComponent } from "react";

const TableHeader: FunctionComponent = ({ children }) => {
  return (
    <div>
      {children && (
        <h1 className="text-xl font-body font-semibold text-green-25 mx-2 mb-2">
          {children}
        </h1>
      )}
      <hr className="border-green-25" />
    </div>
  );
};

export default TableHeader;
