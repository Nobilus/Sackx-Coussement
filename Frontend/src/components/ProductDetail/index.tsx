import { FunctionComponent, useState } from "react";
import Button from "src/components/Button";
import PageLayout from "src/components/Layout/PageLayout";
import Table from "src/components/Table/Table";
import TableHeader from "src/components/Table/TableHeader";
import TableItem from "src/components/Table/TableItem";
import TableRow from "src/components/Table/TableRow";
import { useData } from "src/providers/DataProvider";
import Autocomplete from "../Autocomplete";

interface ProductProps {
  name?: string;
  productGroupName?: string;
  measurmentUnit?: string;
  price?: number;
  priceWithVat?: number;
  productId?: string;
  purchasePrice?: number;
  thickness?: number;
  width?: number;
}

const Product: FunctionComponent<ProductProps> = ({
  name,
  productGroupName,
  purchasePrice,
  measurmentUnit,
  thickness,
  width,
  price,
}) => {
  const { units } = useData();
  const inputClassname =
    "text-baseline font-body font-regular border border-green-100 rounded placeholder-transparent pl-4 py-2 outline-none  bg-white placeholder:text-green-25 text-green-200";

  const initialValues = {
    name: name ?? "",
    productGroupName: productGroupName ?? "",
    purchasePrice: purchasePrice ?? 0,
    price: price ?? 0,
    measurmentUnit: measurmentUnit ?? "",
    thickness: thickness ?? 0,
    width: width ?? 0,
  };

  const [values, setValues] = useState(initialValues);

  const handleTextChanged = (e: any) => {
    console.log(e.target);

    if (e.target.name in values) {
      setValues({ ...values, [e.target.name]: e.target.value });
    }
  };

  const handleDropdownChange = (e: any) => {
    console.log(e);

    if (e.name in values) {
      if (e.name === "measurmentUnit") {
        const unit = units?.find((u) => u.name === e.inputValue);
        setValues({ ...values, [e.name]: unit?.unitId });
      } else {
        setValues({ ...values, [e.name]: e.inputValue });
      }
    }
  };

  const save = () => {
    //   send values
    console.log(values);
  };

  return (
    <PageLayout>
      <Table>
        <TableHeader
          editable={true}
          onChange={handleTextChanged}
          placeholder="product naam"
          value={values.name}
          className="mb-4"
          name={"name"}
        />

        <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Productgroep
          </TableItem>
          <input
            placeholder="Productgroep"
            className={inputClassname}
            type={"text"}
            name={"productGroupName"}
            onChange={handleTextChanged}
            value={values.productGroupName}
          />
        </TableRow>
        <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Aankoopprijs
          </TableItem>
          <input
            placeholder="Aankoopprijs"
            className={inputClassname}
            type={"number"}
            name={"purchasePrice"}
            onChange={handleTextChanged}
            value={values.purchasePrice}
          />
        </TableRow>
        <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Verkoopprijs
          </TableItem>
          <input
            placeholder="Aankoopprijs"
            className={inputClassname}
            type={"number"}
            name={"price"}
            onChange={handleTextChanged}
            value={values.price}
          />
        </TableRow>
        {units && (
          <TableRow cols={2}>
            <TableItem className="place-self-center text-green-25 font-title">
              Eenheid
            </TableItem>
            <Autocomplete
              placeholder="Eenheid"
              items={units.map(({ name }) => name)}
              handleSelectedItemChange={handleDropdownChange}
              name={"measurmentUnit"}
            />
          </TableRow>
        )}
        {/* <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Prijs Excl. BTW
          </TableItem>
          <input
            placeholder="Prijs Excl. BTW"
            className={inputClassname}
            type={"text"}
            name={"exclVat"}
            onChange={handleTextChanged}
            value={values.price}
          />
        </TableRow> */}
        {/* <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Dikte
          </TableItem>

          <input
            placeholder="Dikte"
            className={inputClassname}
            type={"text"}
            name={"thickness"}
            onChange={handleTextChanged}
            value={values.thickness}
          />
        </TableRow>
        <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Breedte
          </TableItem>
          <input
            placeholder="Breedte"
            className={inputClassname}
            type={"text"}
            name={"width"}
            onChange={handleTextChanged}
            value={values.width}
          />
        </TableRow> */}
        <TableRow cols={2}>
          <Button
            className="col-start-2 w-max place-self-end"
            btntype="primary"
            onClick={save}
          >
            Opslaan
          </Button>
        </TableRow>
      </Table>
    </PageLayout>
  );
};

export default Product;
