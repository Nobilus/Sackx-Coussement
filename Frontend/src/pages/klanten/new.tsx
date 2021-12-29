import { FunctionComponent, useState } from "react";
import FormItem from "src/classes/FormItem";
import Form from "src/components/Form";
import PageLayout from "src/components/Layout/PageLayout";

const New: FunctionComponent = () => {
  const [submitting, setSubmitting] = useState(false);

  const validateVATNumber = () => {
    console.log("validating");
  };

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
      onClick: validateVATNumber,
    }),
    new FormItem({
      id: "name",
      name: "name",
      type: "text",
      placeholder: "Naam",
      className: "col-span-2",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "street",
      name: "street",
      type: "text",
      placeholder: "Straat",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "number",
      name: "number",
      type: "text",
      placeholder: "Nummer en bus",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "gemeente",
      name: "gemeente",
      type: "text",
      placeholder: "Gemeente",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "postcode",
      name: "postcode",
      type: "text",
      placeholder: "Postcode",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "land",
      name: "land",
      type: "text",
      placeholder: "Land",
      className: "col-span-2",
      inputClassName: "h-10",
    }),
    new FormItem({
      id: "telefoonnr",
      name: "telefoonnr",
      type: "text",
      placeholder: "Telefoonnummer",
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

  return (
    <PageLayout>
      <Form
        className="mt-32"
        cols={2}
        colGap={20}
        rowGap={8}
        formItems={formItems}
        onSubmit={handleSubmit}
        submitting={submitting}
        setSubmitting={setSubmitting}
      />
    </PageLayout>
  );
};

export default New;
