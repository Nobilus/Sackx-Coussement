import { useRouter } from "next/router";
import { useEffect, useState } from "react";
import ProductDetail from "src/components/ProductDetail";
import { get } from "src/utils/api";

const EditProduct = () => {
  const router = useRouter();
  const { id } = router.query;
  const [product, setProduct] = useState<any>();
  useEffect(() => {
    async function fetchProductdetail() {
      const [error, product] = await get(`/products/${id}`);
      console.log("this is product", product);
      console.log(product);

      setProduct(product);
    }
    console.log(id);

    fetchProductdetail();
  }, [id]);

  // fetch product detail
  // const product = {
  //   productGroup: "Oregon/Douglas",
  //   productName: "Oregon 7x18 tot 6.10m",
  //   purchasePrice: "3.51",
  //   exclVat: "4.50",
  //   unit: "LM",
  //   thickness: "2",
  //   width: "4",
  // };
  if (product) {
    return <ProductDetail {...product} />;
  } else {
    return <></>;
  }
};

export default EditProduct;
