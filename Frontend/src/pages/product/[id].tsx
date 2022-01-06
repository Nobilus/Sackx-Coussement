import { useRouter } from "next/router";
import ProductDetail from "src/components/ProductDetail";

const EditProduct = () => {
  const router = useRouter();
  const { id } = router.query;

  // fetch product detail
  const product = {
    productGroup: "Oregon/Douglas",
    productName: "Oregon 7x18 tot 6.10m",
    purchasePrice: "3.51",
    exclVat: "4.50",
    unit: "LM",
    thickness: "2",
    width: "4",
  };

  return <ProductDetail {...product} />;
};

export default EditProduct;
