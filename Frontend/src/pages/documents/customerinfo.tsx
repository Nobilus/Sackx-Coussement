import debounce from "lodash.debounce";
import Router from "next/router";
import { useState, useEffect, useMemo, ChangeEvent } from "react";
import Button from "src/components/Button";
import TextInput from "src/components/Input/TextInput";
import PageLayout from "src/components/Layout/PageLayout";
import { useData } from "src/providers/DataProvider";

const customerinfo = () => {
  const {
    validateVatNumber,
    customer,
    searchSingleCustomer,
    order,
    orderType,
    createNewOrder,
    updateCustomer,
  } = useData();
  const [customerSearch, setCustomerSearch] = useState("");
  const [vatSearch, setVatSearch] = useState("");

  const handleSubmit = async (e: any) => {
    const orderObject = {
      customer,
      orderType,
      Products: order,
    };
    console.log("this is the order: ", orderObject);

    // @ts-ignore
    const returnedOrder = await createNewOrder(orderObject);
    if (returnedOrder) Router.push("/");
  };

  useEffect(() => {
    console.log(customer);
  }, [customer]);

  const handleSearchChange = (e: any) => {
    setCustomerSearch(e.target.value);
  };

  const debouncedHandleSearchChange = useMemo(
    () => debounce(handleSearchChange, 300),
    []
  );

  const handleVatSearchChange = (e: any) => {
    setVatSearch(e.target.value);
  };

  const deboundedHandleVatSearchChange = useMemo(
    () => debounce(handleVatSearchChange, 300),
    []
  );

  const handleClickSearchCustomer = () => {
    searchSingleCustomer(customerSearch);
  };

  const handleClickSearchByVat = () => {
    validateVatNumber(vatSearch);
  };

  const onTextChange = (event: ChangeEvent<HTMLInputElement>) => {
    const updatedValues = {
      field: event.target.name,
      value: event.target.value,
    };
    updateCustomer(updatedValues);
  };

  return (
    <PageLayout>
      <div className="flex justify-between mb-4">
        <TextInput
          className="col-span-2"
          float={false}
          placeholder="Klant zoeken"
          onChange={debouncedHandleSearchChange}
        />
        <Button btntype="primary" onClick={handleClickSearchCustomer}>
          Zoeken
        </Button>
      </div>
      <div className="flex justify-between mb-20">
        <TextInput
          className="col-span-2"
          float={false}
          placeholder="BTW nummer valideren"
          onChange={deboundedHandleVatSearchChange}
        />
        <Button btntype="primary" onClick={handleClickSearchByVat}>
          Valideren
        </Button>
      </div>

      <form className="grid grid-cols-4 gap-x-20 gap-y-8">
        <TextInput
          className="col-span-2"
          float={false}
          placeholder="BTW nummer"
          value={customer?.vatNumber}
          name={"vatNumber"}
          onChange={onTextChange}
        />
        <TextInput
          className="col-span-2"
          float={false}
          placeholder="Naam"
          value={customer?.customerName}
          name={"customerName"}
          onChange={onTextChange}
        />
        <TextInput
          className="col-span-2"
          float={false}
          placeholder="Straat en nummber"
          value={customer?.street}
          name={"street"}
          onChange={onTextChange}
        />
        <TextInput
          className="col-span-1"
          float={false}
          placeholder="Gemeente"
          value={customer?.city}
          name={"city"}
          onChange={onTextChange}
        />
        <TextInput
          className="col-span-1"
          float={false}
          placeholder="Postcode"
          value={customer?.postal}
          name={"postal"}
          onChange={onTextChange}
        />
        <TextInput
          className="col-span-4"
          float={false}
          placeholder="Telefoonnummer"
          value={customer?.telephone}
          name={"telephone"}
          onChange={onTextChange}
        />
      </form>
      <div className="flex w-full justify-end mt-8">
        <Button btntype="primary" className="" onClick={handleSubmit}>
          Plaats
        </Button>
      </div>
    </PageLayout>
  );
};

export default customerinfo;
