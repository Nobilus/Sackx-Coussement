export interface Product {
  productId: string;
  name: string;
  thickness: number;
  width: number;
  price: number;
  priceWithVat: number;
  purchasePrice: number;
  productGroupName: string;
  measurmentUnit: null | string;
}

export interface ProductWithGroupname {
  productGroupId: number;
  productGroupName: string;
  products: Array<Product>;
}
