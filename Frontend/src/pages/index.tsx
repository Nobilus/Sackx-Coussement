import React, { useEffect } from "react";
import PageLayout from "src/components/Layout/PageLayout";
import { useData } from "src/providers/DataProvider";
import Productgroup from "../components/Productgroup";
import ProductHeader from "../components/Productgroup/header";

export default function Home() {
  const { products } = useData();

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
    </PageLayout>
  );
}
