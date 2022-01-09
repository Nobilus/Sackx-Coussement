import { Customer } from "./Customer";
import { Order } from "./Order";
import { Product, ProductWithGroupname } from "./Products";
import { Unit } from "./Unit";

export interface Data {
  productsWithGroupname: Array<ProductWithGroupname>;
  products: Array<Product>;
  customers: Array<Customer>;
  offertes: Array<Order>;
  bestelbonnen: Array<Array<Order>>;
  loading: boolean;
  customer: null | Customer;
  units: null | Array<Unit>;
}
