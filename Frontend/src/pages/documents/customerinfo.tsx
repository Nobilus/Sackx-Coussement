import debounce from "lodash.debounce";
import { useState, useEffect, useMemo } from "react";
import FormItem from "src/classes/FormItem";
import Button from "src/components/Button";
import Form from "src/components/Form";
import TextInput from "src/components/Input/TextInput";
import PageLayout from "src/components/Layout/PageLayout";
import { useData } from "src/providers/DataProvider";
import { Customer } from "src/types/Customer";

const customerinfo = () => {
  const {
    validateVatNumber,
    customer,
    searchSingleCustomer,
    order,
    orderType,
  } = useData();
  const [customerSearch, setCustomerSearch] = useState("");
  const [vatSearch, setVatSearch] = useState("");
  const [customerInfo, setCustomerInfo] = useState<Customer>();

  function handleSubmit(e: any) {
    console.log(order);
    console.log(orderType);
    console.log(customer);
  }

  useEffect(() => {
    console.log(customer);

    return () => {};
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
        />
        <TextInput
          className="col-span-2"
          float={false}
          placeholder="Naam"
          value={customer?.customerName}
        />
        <TextInput
          className="col-span-2"
          float={false}
          placeholder="Straat en nummber"
          value={customer?.street}
        />
        <TextInput
          className="col-span-1"
          float={false}
          placeholder="Gemeente"
          value={customer?.city}
        />
        <TextInput
          className="col-span-1"
          float={false}
          placeholder="Postcode"
          value={customer?.postal}
        />
        <TextInput
          className="col-span-4"
          float={false}
          placeholder="Telefoonnummer"
          value={customer?.telephone}
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
