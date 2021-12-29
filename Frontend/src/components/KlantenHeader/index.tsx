import Router from "next/router";
import { FunctionComponent, useEffect } from "react";
import { FormItemOption } from "src/classes/FormItem";
import { useFilters } from "src/providers/FilterProvider";
import Button from "../Button";
import Dropdown from "../Dropdown";
import PageHeaderContainer from "../Layout/PageHeaderContainer";

interface KHProps {}

const KlantenHeader: FunctionComponent<KHProps> = ({ children }) => {
  const { updateFilterValue, filters } = useFilters();

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
  return (
    <PageHeaderContainer>
      <Dropdown
        options={options}
        placeholder="type"
        onChange={handleChange}
        name="customerdd"
      />
      <Button btntype="primary" onClick={handleClick}>
        Nieuwe Klant
      </Button>
    </PageHeaderContainer>
  );
};

export default KlantenHeader;
