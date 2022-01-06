import { useRouter } from "next/router";
import React from "react";
import Button from "../Button";
import { MdSearch } from "react-icons/md";

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
      <label className="relative block">
        <span className="sr-only">Search</span>
        <span className="absolute inset-y-0 left-0 flex items-center pl-2">
          <MdSearch className="h-5 w-5 fill-gray-300" />
        </span>
        <input
          className="placeholder:italic placeholder:text-gray-400 block bg-white w-full border border-green-100 rounded py-2 pl-9 pr-3 shadow-sm sm:text-sm"
          placeholder="Zoeken..."
          type="text"
          name="search"
        />
      </label>
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
