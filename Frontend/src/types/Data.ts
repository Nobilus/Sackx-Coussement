import { Bestelbon } from "./Bestelbon";
import { Customer } from "./Customer";
import { Offerte } from "./Offerte";
import { Product } from "./Products";

export interface Data {
  products: Array<{
    productGroupId: number;
    productGroupName: string;
    products: Array<Product>;
  }>;
  customers: Array<Customer>;
  offertes: Array<Offerte>;
  bestelbonnen: Array<Bestelbon>;
}
