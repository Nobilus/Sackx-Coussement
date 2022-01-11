import { FunctionComponent } from "react";
import dateStringToReadable from "src/utils/dateStringToReadable";
import toLocaleCurrency from "src/utils/toLocaleCurrency";
import Button from "../Button";
import TableItem from "../Table/TableItem";
import TableRow from "../Table/TableRow";

interface OffertesItemProps {
  date: string;
  name: string;
  amount: number;
}

const OffertesItem: FunctionComponent<OffertesItemProps> = ({
  date,
  name,
  amount,
}) => {
  return (
    <TableRow cols={4}>
      <TableItem className="my-auto place-self-start">{name}</TableItem>
      <TableItem className="my-auto place-self-center">
        {dateStringToReadable(date)}
      </TableItem>
      <TableItem className="my-auto place-self-end">
        {toLocaleCurrency(amount)}
      </TableItem>
      <TableItem className="place-self-end">
        <Button btntype="primary">Omzetten naar factuur</Button>
      </TableItem>
    </TableRow>
  );
};

export default OffertesItem;
