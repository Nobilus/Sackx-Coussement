import React from "react";
import Productgroup from "../components/Productgroup";
import ProductHeader from "../components/Productgroup/header";
import { Product } from "../types/Products";

const products: Array<Product> = [
  {
    name: "Oregon 7x18 tot 6.10m",
    purchasePrice: 3.51,
    priceExclVat: 4.5,
    priceInclVat: 5.45,
  },
  {
    name: "Oregon 7x18 tot 6.10m",
    purchasePrice: 3.51,
    priceExclVat: 4.5,
    priceInclVat: 5.45,
  },
  {
    name: "Oregon 7x18 tot 6.10m",
    purchasePrice: 3.51,
    priceExclVat: 4.5,
    priceInclVat: 5.45,
  },
  {
    name: "Oregon 7x18 tot 6.10m",
    purchasePrice: 3.51,
    priceExclVat: 4.5,
    priceInclVat: 5.45,
  },
  {
    name: "Oregon 7x18 tot 6.10m",
    purchasePrice: 3.51,
    priceExclVat: 4.5,
    priceInclVat: 5.45,
  },
];

export default function Home() {
  return (
    <>
      <div className="bg-gray-100 max-w-6xl mx-auto">
        <ProductHeader />
        <Productgroup
          key={"productgroup-1"}
          groupname="Oregon/Douglas"
          products={products}
        />
        <Productgroup
          key={"productgroup-2"}
          groupname="Oregon/Douglas"
          products={products}
        />
        <Productgroup
          key={"productgroup-3"}
          groupname="Oregon/Douglas"
          products={products}
        />
        <Productgroup
          key={"productgroup-4"}
          groupname="Oregon/Douglas"
          products={products}
        />
        <Productgroup
          key={"productgroup-5"}
          groupname="Oregon/Douglas"
          products={products}
        />
      </div>
    </>
  );
}
