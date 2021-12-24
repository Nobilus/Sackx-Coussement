import React, { FunctionComponent } from "react";
import { Product } from "../../types/Products";
import Image from "next/image";
import TableHeader from "../Table/TableHeader";
import TableTitle from "../Table/TableTitle";
import TableItem from "../Table/TableItem";
import toLocaleCurrency from "src/utils/toLocaleCurrency";
import Table from "../Table/Table";
import TableRow from "../Table/TableRow";

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
      {products.map(({ name, priceInclVat, priceExclVat, purchasePrice }) => (
        <TableRow>
          <TableItem>{name}</TableItem>
          <TableItem>{toLocaleCurrency(purchasePrice)}</TableItem>
          <TableItem>{toLocaleCurrency(priceInclVat)}</TableItem>
          <TableItem>{toLocaleCurrency(priceExclVat)}</TableItem>
          <Image src={"/assets/Edit.svg"} height={16} width={16} />
        </TableRow>
      ))}
    </Table>
  );
};

export default Productgroup;
