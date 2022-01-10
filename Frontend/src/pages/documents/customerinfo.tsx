import { useState, useEffect } from "react";
import FormItem from "src/classes/FormItem";
import Form from "src/components/Form";
import PageLayout from "src/components/Layout/PageLayout";
import { useData } from "src/providers/DataProvider";

const customerinfo = () => {
  const [submitting, setSubmitting] = useState(false);
  const [vatNumber, setVatNumber] = useState<string>();
  const [changed, setChanged] = useState(false);
  const { validateVatNumber, customer } = useData();

  const valVat = (vatNumber: string | undefined) => {};

  useEffect(() => {
    console.log("this is the vatnumber", vatNumber);

    return () => {};
  }, [vatNumber]);

  const formItems = [
    new FormItem({
      id: "btwnr",
      name: "btwnr",
      type: "text",
      placeholder: "BTW nummer",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "validatebtn",
      name: "validatebtn",
      type: "button",
      btntype: "primary",
      text: "Valideren en gegevens ophalen",
      className: "my-auto",
      onClick: () => valVat(vatNumber),
    }),
    new FormItem({
      id: "name",
      name: "name",
      type: "text",
      placeholder: "Naam",
      value: customer?.customerName,
      className: "col-span-2",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "street",
      name: "street",
      type: "text",
      placeholder: "Straat",
      value: customer?.street,
      inputClassName: "h-10",
    }),

    new FormItem({
      id: "gemeente",
      name: "gemeente",
      value: customer?.city,
      type: "text",
      placeholder: "Gemeente",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "postcode",
      name: "postcode",
      value: customer?.postal,
      type: "text",
      placeholder: "Postcode",
      inputClassName: "h-10",
    }),

    new FormItem({
      id: "telefoonnr",
      name: "telefoonnr",
      type: "text",
      placeholder: "Telefoonnummer",
      value: customer?.telephone,
      className: "col-span-2",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "btnAdd",
      name: "btnAdd",
      type: "button",
      btntype: "primary",
      btnClassName: "",
      text: "Klant toevoegen",
      onClick: () => setSubmitting(true),
      className: "my-auto col-start-2 max-w-max place-self-end",
    }),
  ];

  function handleSubmit(e: any) {
    console.log(e);
  }

  function handleItemChange(e: any) {
    if (e.id === "btwnr") {
      setChanged(!changed);
      setVatNumber(e.value);
      validateVatNumber(e.value);
    }
  }

  return (
    <PageLayout>
      <Form
        className="mt-32"
        cols={2}
        colGap={20}
        rowGap={8}
        onItemChange={handleItemChange}
        formItems={formItems}
        onSubmit={handleSubmit}
        submitting={submitting}
        setSubmitting={setSubmitting}
        changed={changed}
      />
    </PageLayout>
  );
};

export default customerinfo;
