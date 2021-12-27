import React, { FunctionComponent } from "react";
import { Product } from "../../types/Products";
import TableHeader from "../Table/TableHeader";
import TableTitle from "../Table/TableTitle";
import TableItem from "../Table/TableItem";
import toLocaleCurrency from "src/utils/toLocaleCurrency";
import Table from "../Table/Table";
import TableRow from "../Table/TableRow";
import { MdModeEdit } from "react-icons/md";

interface ProductGroupProps {
  groupname: string;
  products: Array<Product>;
}

const titles = ["Naam", "Aankoopprijs", "Prijs excl BTW", "Prijs incl BTW"];

const Productgroup: FunctionComponent<ProductGroupProps> = ({
  groupname,
  products,
}) => {
  return (
    <Table>
      <TableHeader>{groupname}</TableHeader>
      <TableTitle titles={titles} />
      {products.map(
        ({ name, priceInclVat, priceExclVat, purchasePrice }, index) => (
          <TableRow key={`tablerow-${index}`}>
            <TableItem>{name}</TableItem>
            <TableItem>{toLocaleCurrency(purchasePrice)}</TableItem>
            <TableItem>{toLocaleCurrency(priceInclVat)}</TableItem>
            <TableItem>{toLocaleCurrency(priceExclVat)}</TableItem>
            <MdModeEdit />
          </TableRow>
        )
      )}
    </Table>
  );
};

export default Productgroup;