import React, { useEffect } from "react";
import PageLayout from "src/components/Layout/PageLayout";
import { useData } from "src/providers/DataProvider";
import Productgroup from "../components/Productgroup";
import ProductHeader from "../components/Productgroup/header";

export default function Home() {
  const { productsWithGroupname } = useData();

  return (
    <PageLayout>
      <ProductHeader />
      {productsWithGroupname &&
        productsWithGroupname.length > 0 &&
        productsWithGroupname.map((group: any) => (
          <Productgroup
            key={group.productGroupId}
            groupname={group.productGroupName}
            products={group.products}
          />
        ))}
    </PageLayout>
  );
}
