import React, { FunctionComponent } from "react";
import { Product } from "../../types/Products";
import TableHeader from "../Table/TableHeader";
import TableTitle from "../Table/TableTitle";
import TableItem from "../Table/TableItem";
import toLocaleCurrency from "src/utils/toLocaleCurrency";
import Table from "../Table/Table";
import TableRow from "../Table/TableRow";
import { MdModeEdit } from "react-icons/md";
import { useRouter } from "next/router";

interface ProductGroupProps {
  groupname: string;
  products: Array<Product>;
}

const titles = ["Naam", "Aankoopprijs", "Prijs excl BTW", "Prijs incl BTW"];

const Productgroup: FunctionComponent<ProductGroupProps> = ({
  groupname,
  products,
}) => {
  const router = useRouter();

  const handleClickEdit = () => {
    router.push("/product/1");
  };

  return (
    <Table>
      <TableHeader>{groupname}</TableHeader>
      <TableTitle titles={titles} colAmount={5} />
      {products.map(({ name, priceWithVat, price, purchasePrice }, index) => (
        <TableRow key={`tablerow-${index}`}>
          <TableItem>{name}</TableItem>
          <TableItem className={"place-self-center"}>
            {toLocaleCurrency(purchasePrice)}
          </TableItem>
          <TableItem className={"place-self-center"}>
            {toLocaleCurrency(priceWithVat)}
          </TableItem>
          <TableItem className="place-self-end">
            {toLocaleCurrency(price)}
          </TableItem>
          <MdModeEdit
            className="my-auto place-self-end cursor-pointer"
            onClick={handleClickEdit}
          />
        </TableRow>
      ))}
    </Table>
  );
};

export default Productgroup;
