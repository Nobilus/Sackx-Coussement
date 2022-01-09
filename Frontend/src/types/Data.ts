import { Bestelbon } from "./Bestelbon";
import { Customer } from "./Customer";
import { Offerte } from "./Offerte";
import { Order } from "./Order";
import { Product } from "./Products";

export interface Data {
  products: Array<{
    productGroupId: number;
    productGroupName: string;
    products: Array<Product>;
  }>;
  customers: Array<Customer>;
  offertes: Array<Offerte>;
  bestelbonnen: Array<Array<Order>>;
  loading: boolean;
  customer: null | Customer;
}