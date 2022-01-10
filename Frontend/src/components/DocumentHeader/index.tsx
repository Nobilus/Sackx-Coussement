import { useEffect } from "react";
import { FormItemOption } from "src/classes/FormItem";
import { useFilters } from "src/providers/FilterProvider";
import Dropdown from "../Dropdown";
import PageHeaderContainer from "../Layout/PageHeaderContainer";

const DocumentHeader = () => {
  const { updateFilterValue, filters } = useFilters();

  const handleChange = (e: FormItemOption) => {
    updateFilterValue("documenttype", e);
  };

  useEffect(() => {
    console.log(filters);
  }, [filters]);

  const options: Array<FormItemOption> = [
    { id: "bestelbonnen", name: "Bestelbonnen" },
    { id: "offertes", name: "Offertes" },
  ];

  return (
    <PageHeaderContainer className={"w-full"}>
      <Dropdown
        options={options}
        placeholder="type"
        onChange={handleChange}
        name="customerdd"
        className="self-end"
        value={filters.documenttype}
      />
    </PageHeaderContainer>
  );
};

export default DocumentHeader;
