import { FunctionComponent, useState } from "react";
import Button from "src/components/Button";
import PageLayout from "src/components/Layout/PageLayout";
import Table from "src/components/Table/Table";
import TableHeader from "src/components/Table/TableHeader";
import TableItem from "src/components/Table/TableItem";
import TableRow from "src/components/Table/TableRow";

interface ProductProps {
  productName?: string;
  productGroup?: string;
  purchasePrice?: string;
  exclVat?: string;
  unit?: string;
  thickness?: string;
  width?: string;
}

const Product: FunctionComponent<ProductProps> = ({
  productName,
  productGroup,
  purchasePrice,
  exclVat,
  unit,
  thickness,
  width,
}) => {
  const inputClassname =
    "text-baseline font-body font-regular border border-green-100 rounded placeholder-transparent pl-4 py-2 outline-none  bg-white placeholder:text-green-25 text-green-200";

  const initialValues = {
    productName: productName ?? "",
    productGroup: productGroup ?? "",
    purchasePrice: purchasePrice ?? "",
    exclVat: exclVat ?? "",
    unit: unit ?? "",
    thickness: thickness ?? "",
    width: width ?? "",
  };

  const [values, setValues] = useState(initialValues);

  const handleTextChanged = (e: any) => {
    if (e.target.name in values) {
      setValues({ ...values, [e.target.name]: e.target.value });
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
          value={values.productName}
          className="mb-4"
        />

        <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Productgroep
          </TableItem>
          <input
            placeholder="Productgroep"
            className={inputClassname}
            type={"text"}
            name={"productGroup"}
            onChange={handleTextChanged}
            value={values.productGroup}
          />
        </TableRow>
        <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Aankoopprijs
          </TableItem>
          <input
            placeholder="Aankoopprijs"
            className={inputClassname}
            type={"text"}
            name={"purchasePrice"}
            onChange={handleTextChanged}
            value={values.purchasePrice}
          />
        </TableRow>
        <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Eenheid
          </TableItem>
          <input
            placeholder="Eenheid"
            className={inputClassname}
            type={"text"}
            name={"unit"}
            onChange={handleTextChanged}
            value={values.unit}
          />
        </TableRow>
        <TableRow cols={2}>
          <TableItem className="place-self-center text-green-25 font-title">
            Prijs Excl. BTW
          </TableItem>
          <input
            placeholder="Prijs Excl. BTW"
            className={inputClassname}
            type={"text"}
            name={"exclVat"}
            onChange={handleTextChanged}
            value={values.exclVat}
          />
        </TableRow>
        <TableRow cols={2}>
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
        </TableRow>
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
