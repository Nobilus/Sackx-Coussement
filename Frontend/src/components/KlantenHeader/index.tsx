import debounce from "lodash.debounce";
import Router from "next/router";
import { FunctionComponent, useEffect, useMemo } from "react";
import { MdSearch } from "react-icons/md";
import { FormItemOption } from "src/classes/FormItem";
import { useData } from "src/providers/DataProvider";
import { useFilters } from "src/providers/FilterProvider";
import Button from "../Button";
import Dropdown from "../Dropdown";
import PageHeaderContainer from "../Layout/PageHeaderContainer";

interface KHProps {}

const KlantenHeader: FunctionComponent<KHProps> = ({ children }) => {
  const { updateFilterValue, filters } = useFilters();
  const { searchCustomer } = useData();

  const handleClick = () => {
    Router.push("/klanten/new");
  };

  const handleChange = (e: FormItemOption) => {
    updateFilterValue("customertype", e);
  };

  const options: Array<FormItemOption> = [
    { id: "klanten", name: "Klanten" },
    { id: "leveranciers", name: "Leveranciers" },
  ];

  const handleSearchChange = (e: any) => {
    searchCustomer(e.target.value);
  };

  const debouncedHandleSearchChange = useMemo(
    () => debounce(handleSearchChange, 300),
    []
  );

  return (
    <PageHeaderContainer>
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
          onChange={debouncedHandleSearchChange}
        />
      </label>
      {/* <Dropdown
        options={options}
        placeholder="type"
        onChange={handleChange}
        name="customerdd"
      /> */}
      <Button btntype="primary" onClick={handleClick}>
        Nieuwe Klant
      </Button>
    </PageHeaderContainer>
  );
};

export default KlantenHeader;
