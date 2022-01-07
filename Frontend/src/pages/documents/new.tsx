import { useEffect, useState } from "react";
import dynamic from "next/dynamic";
import Button from "src/components/Button";
import TextInput from "src/components/Input/TextInput";
import PageLayout from "src/components/Layout/PageLayout";
import Table from "src/components/Table/Table";
import TableHeader from "src/components/Table/TableHeader";
import TableRow from "src/components/Table/TableRow";
import TableTitle from "src/components/Table/TableTitle";
import { MdClose } from "react-icons/md";

const Autocomplete = dynamic(import("src/components/Autocomplete"), {
  ssr: false,
});

const New = () => {
  const titles = ["Product", "Aantal", "Eenheid", "Stukprijs"];

  const [products, setProducts] = useState([{}]);

  const addProduct = () => {
    setProducts([...products, {}]);
  };

  const removeProduct = (e: any) => {
    const newArr = products;
    const index = Number(e.target.id);
    newArr.splice(index, 1);
    setProducts([...newArr]);
  };

  const items = [
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
  const handleContinue = () => {};

  const handleSelectedChange = (e: any) => {
    const index = e.name;
    const type = e.id;
    const value = e.selectedItem;

    const newProducts = [
      ...products.slice(0, index),
      { ...products[index], [type]: value },
      ...products.slice(index + 1),
    ];

    setProducts(newProducts);
  };

  const handleTextChange = (e: any) => {
    const value = e.target.value;
    const index = e.target.name;
    const type = e.target.id;

    const newProducts = [
      ...products.slice(0, index),
      { ...products[index], [type]: value },
      ...products.slice(index + 1),
    ];

    setProducts(newProducts);
  };

  useEffect(() => {
    console.table(products);
  }, [products]);

  return (
    <PageLayout>
      <Table>
        <TableHeader>Bestelbon</TableHeader>
        <TableTitle titles={titles} colAmount={5} />
        {products.map((product, i) => {
          return (
            <TableRow key={`tablerow-${i}`}>
              <Autocomplete
                className="place-self-start mr-9"
                placeholder={"Product"}
                items={items}
                handleSelectedItemChange={handleSelectedChange}
                name={`${i}`}
                id={"product"}
              />
              <TextInput
                type="number"
                className=" mx-20"
                min={1}
                placeholder="Aantal"
                float={false}
                onChange={handleTextChange}
                name={`${i}`}
                id={"amount"}
              />
              <Autocomplete
                className=" mx-16"
                placeholder={"Eenheid"}
                items={items}
                handleSelectedItemChange={handleSelectedChange}
                name={`${i}`}
                id={"unit"}
              />
              <span className="flex place-self-center my-auto items-center ml-36">
                <p className="mr-1">€</p>
                <TextInput placeholder="Prijs" float={false} type="number" />
              </span>
              <MdClose
                id={`${i}`}
                className="place-self-end cursor-pointer m-auto"
                onClick={removeProduct}
              />
            </TableRow>
          );
        })}
      </Table>
      <div className="grid grid-cols-3">
        <Button
          className="col-start-2 w-max place-self-center"
          btntype="secondary"
          onClick={addProduct}
        >
          Voeg product toe
        </Button>
        <Button
          className="col-start-3 w-max place-self-end"
          btntype="primary"
          onClick={handleContinue}
        >
          Verder
        </Button>
      </div>
    </PageLayout>
  );
};

export default New;
