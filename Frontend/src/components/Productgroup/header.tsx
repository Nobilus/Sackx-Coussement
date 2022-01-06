import { useRouter } from "next/router";
import React from "react";
import Button from "../Button";

const ProductHeader = () => {
  const router = useRouter();

  const clickNieuwProduct = () => {
    router.push("/product/new");
  };

  const clickNieuweBestelbon = () => {
    router.push("/document/new/bestelbon");
  };

  return (
    <div className="container flex flex-row justify-between mx-auto mb-16">
      {/* search item */}
      <input type="text" className="border border-green" />
      <div>
        <Button btntype="secondary" onClick={clickNieuwProduct}>
          Nieuw product
        </Button>
        <Button
          btntype="primary"
          className="ml-8"
          onClick={clickNieuweBestelbon}
        >
          Nieuwe bestelbon
        </Button>
      </div>
    </div>
  );
};

export default ProductHeader;
