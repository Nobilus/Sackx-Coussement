import { FunctionComponent } from "react";
import { BestelbonEntry } from "src/types/Bestelbon";
import TableHeader from "../Table/TableHeader";
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
    <div>
      <TableHeader />
      <TableTitle titles={tableTitles} />
    </div>
  );
};

export default BestelbonItem;
