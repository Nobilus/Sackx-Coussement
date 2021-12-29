import React, { useState } from "react";
import BestelbonItem from "src/components/Bestelbon";
import DocumentHeader from "src/components/DocumentHeader";
import PageLayout from "src/components/Layout/PageLayout";
import OffertesItem from "src/components/Offertes";
import Table from "src/components/Table/Table";
import TableHeader from "src/components/Table/TableHeader";
import TableTitle from "src/components/Table/TableTitle";
import { useFilters } from "src/providers/FilterProvider";
import { Bestelbon } from "src/types/Bestelbon";
import { Offerte } from "src/types/Offerte";

const bestelbonnen: Array<Bestelbon> = [
  {
    customer: "Tom De Meyer",
    entries: [
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
    ],
  },
  {
    customer: "Jonas De Meyer",
    entries: [
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
      { date: "01/02/03", amount: 320.5 },
    ],
  },
];

const offertes: Array<Offerte> = [
  {
    date: "12/06/2021",
    name: "Tom De Meyer",
    amount: 320.5,
  },
  {
    date: "12/06/2021",
    name: "Tom De Meyer",
    amount: 320.5,
  },
  {
    date: "12/06/2021",
    name: "Tom De Meyer",
    amount: 320.5,
  },
  {
    date: "12/06/2021",
    name: "Tom De Meyer",
    amount: 320.5,
  },
  {
    date: "12/06/2021",
    name: "Tom De Meyer",
    amount: 320.5,
  },
  {
    date: "12/06/2021",
    name: "Tom De Meyer",
    amount: 320.5,
  },
  {
    date: "12/06/2021",
    name: "Tom De Meyer",
    amount: 320.5,
  },
];

const offerteTableTitles = ["Naam", "Datum", "Bedrag"];

const Bestelbonnen = () => {
  const { filters } = useFilters();

  if (filters.documenttype.name === "Bestelbonnen") {
    return (
      <PageLayout>
        <DocumentHeader />
        <Table>
          {bestelbonnen.map(({ customer, entries }, i) => (
            <BestelbonItem
              name={customer}
              entries={entries}
              key={`bestelbonitem-${i}`}
            />
          ))}
        </Table>
      </PageLayout>
    );
  } else {
    return (
      <PageLayout>
        <DocumentHeader />
        <Table>
          <TableHeader />
          <TableTitle titles={offerteTableTitles} colAmount={4} />
          {offertes.map((offerte, i) => (
            <OffertesItem {...offerte} key={`offerteitem-${i}`} />
          ))}
        </Table>
      </PageLayout>
    );
  }
};

export default Bestelbonnen;
