import React, { useEffect, useState } from "react";
import KlantenHeader from "src/components/KlantenHeader";
import PageHeaderContainer from "src/components/Layout/PageHeaderContainer";
import PageLayout from "src/components/Layout/PageLayout";
import Table from "src/components/Table/Table";
import TableHeader from "src/components/Table/TableHeader";
import TableItem from "src/components/Table/TableItem";
import TableRow from "src/components/Table/TableRow";
import TableTitle from "src/components/Table/TableTitle";
import { Customer } from "src/types/Customer";
import { get } from "src/utils/api";

const customer: Array<Customer> = [
  {
    name: "Amazon",
    email: "info@amazon.com",
    telephone: "0471814125",
    contactperson: "Jeff Bezos",
  },
  {
    name: "Amazon",
    email: "info@amazon.com",
    telephone: "0471814125",
    contactperson: "Jeff Bezos",
  },
  {
    name: "Amazon",
    email: "info@amazon.com",
    telephone: "0471814125",
    contactperson: "Jeff Bezos",
  },
  {
    name: "Amazon",
    email: "info@amazon.com",
    telephone: "0471814125",
    contactperson: "Jeff Bezos",
  },
  {
    name: "Amazon",
    email: "info@amazon.com",
    telephone: "0471814125",
    contactperson: "Jeff Bezos",
  },
  {
    name: "Amazon",
    email: "info@amazon.com",
    telephone: "0471814125",
    contactperson: "Jeff Bezos",
  },
  {
    name: "Amazon",
    email: "info@amazon.com",
    telephone: "0471814125",
    contactperson: "Jeff Bezos",
  },
  {
    name: "Amazon",
    email: "info@amazon.com",
    telephone: "0471814125",
    contactperson: "Jeff Bezos",
  },
  {
    name: "Amazon",
    email: "info@amazon.com",
    telephone: "0471814125",
    contactperson: "Jeff Bezos",
  },
];

const titles = ["Naam", "E-mail", "Telefoon", "Contactpersoon"];

const Klanten = () => {
  const [customers, setCustomers] = useState<any>();
  useEffect(() => {
    async function getCustomers() {
      const [error, customers] = await get("/customers");
      setCustomers(customers);
    }
    getCustomers();
  }, []);
  return (
    <PageLayout>
      <KlantenHeader />
      <Table>
        <TableHeader />
        <TableTitle titles={titles} />
        {customers &&
          customers.length > 0 &&
          customers.map(({ customerName, email, telephone, firstName }, i) => (
            <TableRow cols={4} key={`tablerow-${i}`}>
              <TableItem className="place-self-start">{customerName}</TableItem>
              <TableItem className="place-self-center">email</TableItem>
              <TableItem className="place-self-center">telephone</TableItem>
              <TableItem className="place-self-end">{firstName}</TableItem>
            </TableRow>
          ))}
      </Table>
    </PageLayout>
  );
};

export default Klanten;
