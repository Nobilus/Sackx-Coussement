import React from "react";
import KlantenHeader from "src/components/KlantenHeader";
import PageHeaderContainer from "src/components/Layout/PageHeaderContainer";
import PageLayout from "src/components/Layout/PageLayout";
import Table from "src/components/Table/Table";
import TableHeader from "src/components/Table/TableHeader";
import TableItem from "src/components/Table/TableItem";
import TableRow from "src/components/Table/TableRow";
import TableTitle from "src/components/Table/TableTitle";
import { Customer } from "src/types/Customer";

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
  return (
    <PageLayout>
      <KlantenHeader />
      <Table>
        <TableHeader />
        <TableTitle titles={titles} />
        {customer.map(({ name, email, telephone, contactperson }) => (
          <TableRow cols={4}>
            <TableItem className="place-self-start">{name}</TableItem>
            <TableItem className="place-self-center">{email}</TableItem>
            <TableItem className="place-self-center">{telephone}</TableItem>
            <TableItem className="place-self-end">{contactperson}</TableItem>
          </TableRow>
        ))}
      </Table>
    </PageLayout>
  );
};

export default Klanten;
