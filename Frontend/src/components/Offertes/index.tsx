import { FunctionComponent } from "react";
import toLocaleCurrency from "src/utils/toLocaleCurrency";
import Button from "../Button";
import TableHeader from "../Table/TableHeader";
import TableItem from "../Table/TableItem";
import TableRow from "../Table/TableRow";
import TableTitle from "../Table/TableTitle";

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
      <TableItem className="my-auto place-self-center">{date}</TableItem>
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
