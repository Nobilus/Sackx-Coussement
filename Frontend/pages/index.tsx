import Head from "next/head";
import Image from "next/image";
import React from "react";
import Footer from "../components/Footer";
import Productgroup from "../components/Productgroup";
import styles from "../styles/Home.module.css";
import { Product } from "../types/Products";
import Login from "./login";

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
      <Productgroup groupname="Oregon/Douglas" products={products} />
      <Footer />
    </>
  );
}
