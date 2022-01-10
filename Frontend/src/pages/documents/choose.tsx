import Router from "next/router";
import { FunctionComponent } from "react";
import { FaFileInvoiceDollar, FaReceipt, FaFileInvoice } from "react-icons/fa";
import PageLayout from "src/components/Layout/PageLayout";
import { useData } from "src/providers/DataProvider";

interface ItemProps {
  type: "bestelbon" | "factuur" | "offerte";
}

const Item: FunctionComponent<ItemProps> = ({ type }) => {
  const { setOrderType } = useData();

  const handleClickOfferte = () => {
    setOrderType("offerte");
    Router.push("/documents/customerinfo");
  };
  const handleClickBestelbon = () => {
    setOrderType("bestelbon");
    Router.push("/documents/customerinfo");
  };
  const handleClickFactuur = () => {
    setOrderType("factuur");
    Router.push("/documents/customerinfo");
  };

  if (type === "bestelbon") {
    return (
      <div className="m-auto">
        <div
          onClick={handleClickBestelbon}
          className="bg-green-700 flex flex-col items-center px-24 pt-16 rounded cursor-pointer hover:bg-green-600"
        >
          <FaReceipt color="white" size={90} />
          <p className=" text-white font-bold mt-10 mb-4">Bestelbon</p>
        </div>
      </div>
    );
  } else if (type === "offerte") {
    return (
      <div className="m-auto">
        <div
          onClick={handleClickOfferte}
          className=" bg-green-700 flex flex-col items-center px-24 pt-16 rounded cursor-pointer hover:bg-green-600"
        >
          <FaFileInvoice color="white" size={90} />
          <p className=" text-white font-bold mt-10 mb-4">Offerte</p>
        </div>
      </div>
    );
  } else {
    return (
      <div className="m-auto">
        <div
          onClick={handleClickFactuur}
          className=" bg-green-700 flex flex-col items-center px-24 pt-16 rounded cursor-pointer hover:bg-green-600"
        >
          <FaFileInvoiceDollar color="white" size={90} />
          <p className=" text-white font-bold mt-10 mb-4">Factuur</p>
        </div>
      </div>
    );
  }
};

const Choose = () => {
  return (
    <div className=" mt-56">
      <PageLayout>
        <div className="grid grid-cols-3">
          <Item type="offerte" />
          <Item type="bestelbon" />
          <Item type="factuur" />
        </div>
      </PageLayout>
    </div>
  );
};

export default Choose;
