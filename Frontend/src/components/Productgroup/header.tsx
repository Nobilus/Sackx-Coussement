import { useRouter } from "next/router";
import React from "react";
import Button from "../Button";
import { MdSearch } from "react-icons/md";
import Autocomplete from "../Autocomplete";

const ProductHeader = () => {
  const router = useRouter();

  const clickNieuwProduct = () => {
    router.push("/product/new");
  };

  const clickNieuweBestelbon = () => {
    router.push("/document/new/bestelbon");
  };

  const groups = [
    "Alabama",
    "Alaska",
    "American Samoa",
    "Arizona",
    "Arkansas",
    "California",
    "Colorado",
    "Connecticut",
    "Delaware",
    "District of Columbia",
    "Federated States of Micronesia",
    "Florida",
    "Georgia",
    "Guam",
    "Hawaii",
    "Idaho",
    "Illinois",
    "Indiana",
    "Iowa",
    "Kansas",
    "Kentucky",
    "Louisiana",
    "Maine",
    "Marshall Islands",
    "Maryland",
    "Massachusetts",
    "Michigan",
    "Minnesota",
    "Mississippi",
    "Missouri",
    "Montana",
    "Nebraska",
    "Nevada",
    "New Hampshire",
    "New Jersey",
    "New Mexico",
    "New York",
    "North Carolina",
    "North Dakota",
    "Northern Mariana Islands",
    "Ohio",
    "Oklahoma",
    "Oregon",
    "Palau",
    "Pennsylvania",
    "Puerto Rico",
    "Rhode Island",
    "South Carolina",
    "South Dakota",
    "Tennessee",
    "Texas",
    "Utah",
  ];

  return (
    <div className="container flex flex-row justify-between mx-auto mb-16">
      {/* search item */}
      <div className="flex">
        <label className="relative block">
          <span className="sr-only">Search</span>
          <span className="absolute inset-y-0 right-0 flex items-center pr-2">
            <MdSearch className="h-5 w-5 fill-gray-300" />
          </span>
          <input
            className="placeholder:italic placeholder:text-gray-400 block bg-white w-full border border-green-100 rounded py-2 pl-2 pr-3 shadow-sm sm:text-sm"
            placeholder="Zoeken..."
            type="text"
            name="search"
          />
        </label>
        <Autocomplete
          placeholder="Productgroep"
          items={groups}
          className="ml-8"
        />
      </div>
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
