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
import { useData } from "src/providers/DataProvider";
import { NewOrder } from "src/types/Order";
import Router from "next/router";

const Autocomplete = dynamic(import("src/components/Autocomplete"), {
  ssr: false,
});

const New = () => {
  const {
    units,
    products: items,
    searchSingleProduct,
    storeOrder,
    order,
  } = useData();

  const emptyProduct = { product: undefined, price: 0, amount: 0, unit: "" };
  const titles = ["Product", "Aantal", "Eenheid", "Stukprijs"];
  const [products, setProducts] = useState<Array<NewOrder>>([emptyProduct]);

  const addProduct = () => {
    setProducts([...products, emptyProduct]);
  };

  const removeProduct = (e: any) => {
    const newArr = products;
    const index = Number(e.target.id);
    newArr.splice(index, 1);
    setProducts([...newArr]);
  };

  const handleContinue = () => {
    storeOrder(products);
    Router.push("/documents/choose");
  };

  useEffect(() => {
    console.log(order);

    return () => {};
  }, [order]);

  const handleSelectedChange = async (e: any) => {
    const index = e.name;
    const type = e.id;
    const value = e.selectedItem;

    if (type === "product") {
      const product = await searchSingleProduct(value);
      console.log(product);

      const newProducts = [
        ...products.slice(0, index),
        {
          ...products[index],
          [type]: product[0],
          price: product[0].priceWithVat,
        },
        ...products.slice(index + 1),
      ];
      setProducts(newProducts);
    } else {
      const newProducts = [
        ...products.slice(0, index),
        {
          ...products[index],
          [type]: value,
        },
        ...products.slice(index + 1),
      ];
      setProducts(newProducts);
    }
  };

  const handleTextChange = (e: any) => {
    const value = Number(e.target.value);
    const index = e.target.name;
    const type = e.target.id;
    console.log({ value, index, type });

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
                items={items.map(({ name }) => name)}
                handleSelectedItemChange={handleSelectedChange}
                name={`${i}`}
                id={"product"}
              />
              <TextInput
                type="number"
                className=" mx-20"
                placeholder="Aantal"
                float={false}
                min={1}
                value={products[i].amount}
                onChange={handleTextChange}
                name={`${i}`}
                id={"amount"}
              />
              <Autocomplete
                className=" mx-16"
                placeholder={"Eenheid"}
                items={units?.map(({ name }) => name)}
                handleSelectedItemChange={handleSelectedChange}
                name={`${i}`}
                id={"unit"}
              />
              <span className="flex place-self-center my-auto items-center ml-36">
                <p className="mr-1">€</p>
                <TextInput
                  placeholder="Prijs"
                  float={false}
                  type="number"
                  min={0}
                  value={product.price}
                  onChange={handleTextChange}
                  id="price"
                />
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
