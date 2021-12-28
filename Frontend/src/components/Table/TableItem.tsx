import classNames from "classnames/bind";
import { FunctionComponent } from "react";

interface TableItemProps {
  className?: string;
}

const TableItem: FunctionComponent<TableItemProps> = ({
  children,
  className,
}) => {
  return <p className={classNames("text-lg", className)}>{children}</p>;
};

export default TableItem;
