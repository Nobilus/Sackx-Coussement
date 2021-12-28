import classNames from "classnames/bind";
import { FunctionComponent, useState } from "react";

interface TableRowProps {
  cols?: number;
  className?: string;
}

const TableRow: FunctionComponent<TableRowProps> = ({
  children,
  cols,
  className,
}) => {
  const [colAmount] = useState(cols ? cols : 5);

  return (
    <div
      className={classNames(
        "grid mx-2 mb-4",
        [`grid-cols-${colAmount}`],
        [className]
      )}
    >
      {children}
    </div>
  );
};

export default TableRow;
