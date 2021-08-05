import React, { FunctionComponent } from "react";
import { Product } from "../../types/Products";

interface ProductGroupProps {
  groupname: string;
  products: Array<Product>;
}

const Productgroup: FunctionComponent<ProductGroupProps> = ({
  groupname,
  products,
}) => {
  return (
    <section className="container mx-auto">
      <div>
        <h1 className="text-lg font-body text-green-25 mx-2">{groupname}</h1>
        <hr className="border-green-25" />
      </div>
      <div className="grid grid-cols-5 mx-2 mt-4 mb-2">
        <p className="text-green-25 text-lg">Naam</p>
        <p className="text-green-25 text-lg">Aankoopprijs</p>
        <p className="text-green-25 text-lg">Prijs excl BTW</p>
        <p className="text-green-25 text-lg">Prijs incl BTW</p>
      </div>
      <article>
        {products.map(({ name, priceInclVat, priceExclVat, purchasePrice }) => (
          <div className="grid grid-cols-5 mx-2 mb-4">
            <p className="font-body text-lg">{name}</p>
            <p className="font-body text-lg">{purchasePrice}</p>
            <p className="font-body text-lg">{priceInclVat}</p>
            <p className="font-body text-lg">{priceExclVat}</p>
          </div>
        ))}
      </article>
    </section>
  );
};

export default Productgroup;
