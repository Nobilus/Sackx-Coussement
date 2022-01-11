import React, { useEffect } from "react";
import KlantenHeader from "src/components/KlantenHeader";
import PageLayout from "src/components/Layout/PageLayout";
import Table from "src/components/Table/Table";
import TableHeader from "src/components/Table/TableHeader";
import TableItem from "src/components/Table/TableItem";
import TableRow from "src/components/Table/TableRow";
import TableTitle from "src/components/Table/TableTitle";
import { useData } from "src/providers/DataProvider";

const titles = ["Naam", "E-mail", "Fax", "Contactpersoon"];

const Klanten = () => {
  const { customers } = useData();

  return (
    <PageLayout>
      <KlantenHeader />
      <Table>
        <TableHeader />
        <TableTitle titles={titles} />
        {customers &&
          customers.length > 0 &&
          customers.map(({ customerName, email, fax, contact1 }, i) => (
            <TableRow cols={4} key={`tablerow-${i}`}>
              <TableItem className="place-self-start">{customerName}</TableItem>
              <TableItem className="place-self-center">
                {email ?? "-"}
              </TableItem>
              <TableItem className="place-self-center">
                {fax.length > 0 ? fax : "-"}
              </TableItem>
              <TableItem className="place-self-end">
                {contact1.length > 0 ? contact1 : "-"}
              </TableItem>
            </TableRow>
          ))}
      </Table>
    </PageLayout>
  );
};

export default Klanten;
