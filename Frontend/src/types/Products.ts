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
