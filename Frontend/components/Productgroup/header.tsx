import React from "react";

const ProductHeader = () => {
  return (
    <div className="container flex flex-row justify-between mx-auto mb-16">
      {/* search item */}
      <input type="text" className="border border-green" />
      <div>
        <button className="rounded border border-green bg-white px-4 py-2 text-green">
          Nieuw product
        </button>
        <button className="rounded border border-green bg-green px-4 py-2 text-white ml-8">
          Nieuwe bestelbon
        </button>
      </div>
    </div>
  );
};

export default ProductHeader;
