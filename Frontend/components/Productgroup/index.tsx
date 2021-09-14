import React, { FunctionComponent } from "react";
import { Product } from "../../types/Products";
import Edit from "../../public/assets/Edit.svg";

interface ProductGroupProps {
  groupname: string;
  products: Array<Product>;
}

const Productgroup: FunctionComponent<ProductGroupProps> = ({
  groupname,
  products,
}) => {
  return (
    <section className="container mx-auto mb-8">
      <div>
        <h1 className="text-lg font-body font-semibold text-green-25 mx-2 mb-2">
          {groupname}
        </h1>
        <hr className="border-green-25" />
      </div>
      <div className="grid grid-cols-5 mx-2 mt-4 mb-2">
        <p className="font-title text-green-25 text-md">Naam</p>
        <p className="font-title text-green-25 text-md">Aankoopprijs</p>
        <p className="font-title text-green-25 text-md">Prijs excl BTW</p>
        <p className="font-title text-green-25 text-md">Prijs incl BTW</p>
      </div>
      <article>
        {products.map(({ name, priceInclVat, priceExclVat, purchasePrice }) => (
          <div className="grid grid-cols-5 mx-2 mb-4">
            <p className="text-lg">{name}</p>
            <p className="text-lg">
              €
              {purchasePrice.toLocaleString("be-NL", {
                minimumFractionDigits: 2,
              })}
            </p>
            <p className="text-lg">
              €
              {priceInclVat.toLocaleString("be-NL", {
                minimumFractionDigits: 2,
              })}
            </p>
            <p className="text-lg">
              €
              {priceExclVat.toLocaleString("be-NL", {
                minimumFractionDigits: 2,
              })}
            </p>
            <Edit className="mx-auto" />
          </div>
        ))}
      </article>
    </section>
  );
};

export default Productgroup;
