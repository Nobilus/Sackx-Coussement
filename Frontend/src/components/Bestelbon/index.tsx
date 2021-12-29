import { FunctionComponent } from "react";
import { BestelbonEntry } from "src/types/Bestelbon";
import toLocaleCurrency from "src/utils/toLocaleCurrency";
import Button from "../Button";
import Table from "../Table/Table";
import TableHeader from "../Table/TableHeader";
import TableItem from "../Table/TableItem";
import TableRow from "../Table/TableRow";
import TableTitle from "../Table/TableTitle";

interface BestelbonItemProps {
  name: string;
  entries: Array<BestelbonEntry>;
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
      {entries.map(({ date, amount }, i) => {
        return (
          <TableRow cols={3} key={`tablerow-${i}`}>
            <TableItem className="place-self-start">
              {i === 0 ? name : ""}
            </TableItem>
            <TableItem className="place-self-center">{date}</TableItem>
            <TableItem className="place-self-end">
              {toLocaleCurrency(amount)}
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
