import React from "react";
import BestelbonItem from "src/components/Bestelbon";
import PageLayout from "src/components/Layout/PageLayout";
import Table from "src/components/Table/Table";
import { Bestelbon } from "src/types/Bestelbon";

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

const Bestelbonnen = () => {
  return (
    <PageLayout>
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
};

export default Bestelbonnen;
