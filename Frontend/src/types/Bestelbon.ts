export interface BestelbonEntry {
  date: string;
  amount: number;
}

export interface Bestelbon {
  customer: string;
  entries: Array<BestelbonEntry>;
}
