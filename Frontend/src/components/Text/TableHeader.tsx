import { FunctionComponent } from "react";

interface TableHeaderProps {
  groupname: string;
}

const TableHeader: FunctionComponent<TableHeaderProps> = ({ groupname }) => {
  return (
    <div>
      <h1 className="text-lg font-body font-semibold text-green-25 mx-2 mb-2">
        {groupname}
      </h1>
      <hr className="border-green-25" />
    </div>
  );
};

export default TableHeader;
