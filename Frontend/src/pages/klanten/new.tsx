import debounce from "lodash.debounce";
import Router from "next/router";
import {
  ChangeEvent,
  FunctionComponent,
  useEffect,
  useMemo,
  useState,
} from "react";
import FormItem from "src/classes/FormItem";
import Button from "src/components/Button";
import Form from "src/components/Form";
import TextInput from "src/components/Input/TextInput";
import PageLayout from "src/components/Layout/PageLayout";
import { useData } from "src/providers/DataProvider";

const New: FunctionComponent = () => {
  const { validateVatNumber, customer, updateCustomer, createCustomer } =
    useData();

  const handleSubmit = async (e: any) => {
    if (customer) {
      const c = await createCustomer(customer);
      if (c) Router.push("/klanten");
    }
  };

  useEffect(() => {
    console.log(customer);
  }, [customer]);

  const handleClickSearchByVat = () => {
    const vat = customer?.vatNumber;
    if (vat) {
      validateVatNumber(vat);
    }
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
      <div className="grid grid-cols-4 gap-x-20 gap-y-8 mt-52">
        <TextInput
          className="col-span-2"
          float={false}
          placeholder="BTW nummer"
          value={customer?.vatNumber}
          name={"vatNumber"}
          onChange={onTextChange}
        />
        <Button
          btntype="primary"
          className="col-span-2"
          onClick={handleClickSearchByVat}
        >
          Valideren en gegevens ophalen
        </Button>
        <TextInput
          className="col-span-4"
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
      </div>
      <div className="flex w-full justify-end mt-8">
        <Button btntype="primary" className="" onClick={handleSubmit}>
          Klant toevoegen
        </Button>
      </div>
    </PageLayout>
  );
};

export default New;
