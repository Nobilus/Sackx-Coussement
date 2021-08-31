import Head from "next/head";
import Image from "next/image";
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
      <ProductHeader />
      <Productgroup groupname="Oregon/Douglas" products={products} />
    </>
  );
}
