import { Customer } from "./Customer";
import { Order } from "./Order";
import { Product } from "./Products";
import { Unit } from "./Unit";

export interface Data {
  products: Array<{
    productGroupId: number;
    productGroupName: string;
    products: Array<Product>;
  }>;
  customers: Array<Customer>;
  offertes: Array<Order>;
  bestelbonnen: Array<Array<Order>>;
  loading: boolean;
  customer: null | Customer;
  units: null | Array<Unit>;
}
