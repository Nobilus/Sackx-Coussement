import React, { useEffect, useState } from "react";
import PageLayout from "src/components/Layout/PageLayout";
import { get } from "src/utils/api";
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
  const [products, setProducts] = useState<any>();
  useEffect(() => {
    async function getProducts() {
      const [error, products] = await get(`/products/withgroups`);
      // console.log(products);

      // return products;

      return setProducts(products);
    }
    getProducts();
  }, []);

  useEffect(() => {
    console.log(products);

    return () => {};
  }, [products]);

  return (
    <PageLayout>
      <ProductHeader />
      {products &&
        products.length > 0 &&
        products.map((group: any) => (
          <Productgroup
            key={group.productGroupId}
            groupname={group.productGroupName}
            products={group.products}
          />
        ))}
      {/* {products && (
        <>
        products
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
        </>
      )} */}
    </PageLayout>
  );
}
