import { FunctionComponent, useEffect } from "react";

import { BestelbonEntry } from "src/types/Bestelbon";
import { Order } from "src/types/Order";
import toLocaleCurrency from "src/utils/toLocaleCurrency";
import Button from "../Button";
import Table from "../Table/Table";
import TableHeader from "../Table/TableHeader";
import TableItem from "../Table/TableItem";
import TableRow from "../Table/TableRow";
import TableTitle from "../Table/TableTitle";

interface BestelbonItemProps {
  name: string;
  entries: Array<Order>;
}

const BestelbonItem: FunctionComponent<BestelbonItemProps> = ({
  name,
  entries,
}) => {
  const tableTitles = ["Naam", "Datum", "Bedrag"];

  return (
    <>
      <TableHeader />
      <TableTitle titles={tableTitles} />
      {entries.map(({ date, indebted }, i) => {
        const newDate = new Date(date).toISOString().split("T")[0];
        return (
          <TableRow cols={3} key={`tablerow-${i}`}>
            <TableItem className="place-self-start">
              {i === 0 ? name : ""}
            </TableItem>
            <TableItem className="place-self-center">{newDate}</TableItem>
            <TableItem className="place-self-end">
              {toLocaleCurrency(indebted)}
            </TableItem>
          </TableRow>
        );
      })}
      <TableRow cols={1} className={"mt-14"}>
        <TableItem className="place-self-end">
          <Button btntype={"primary"}>Omzetten naar factuur</Button>
        </TableItem>
      </TableRow>
    </>
  );
};

export default BestelbonItem;
