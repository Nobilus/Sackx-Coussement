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
