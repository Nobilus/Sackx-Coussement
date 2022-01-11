import { Customer } from "./Customer";
import { Product } from "./Products";

export interface OrderDetail extends Product {
  quantity: number;
}

export interface Order {
  id: string;
  customerId: string;
  date: string;
  firstname: string;
  customerName: string;
  street: string;
  postal: number;
  city: string;
  indebted: number;
  vat: number;
  orderType: "bestelbon" | "offerte";
  isPayed: false;
  orderDetails: Array<OrderDetail>;
}

export interface NewOrder {
  product?: Product;
  price: number;
  amount: number;
  unit: string;
}

export interface CreateNewOrder {
  customer: Customer | null;
  orderType: "offerte" | "bestelbon" | "factuur" | undefined;
  order: NewOrder[] | undefined;
}
