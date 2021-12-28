import React from "react";
import PageLayout from "src/components/Layout/PageLayout";
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
  return <PageLayout></PageLayout>;
};

export default Bestelbonnen;
