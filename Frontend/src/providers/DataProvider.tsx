import { useRouter } from "next/router";
import {
  createContext,
  FunctionComponent,
  useContext,
  useEffect,
  useReducer,
  useState,
} from "react";
import { Bestelbon } from "src/types/Bestelbon";
import { Customer } from "src/types/Customer";
import { Data } from "src/types/Data";
import { Offerte } from "src/types/Offerte";
import { Product } from "src/types/Products";
import { get } from "src/utils/api";

interface IDataProviderContext {
  searchCustomer: (query: string) => Promise<void>;
  clearSearchCustomer: () => void;
  searchProduct: (product: string) => Promise<void>;
  clearSearchProduct: () => Promise<void>;
  products: any;
  customers: Customer[];
  offertes: Offerte[];
  bestelbonnen: Bestelbon[];
}

const DataProviderContext = createContext<IDataProviderContext>(
  {} as IDataProviderContext
);

export function useData() {
  return useContext(DataProviderContext);
}

function reducer(state: Data, action: { type: string; payload: any }) {
  switch (action.type) {
    case "addProducts":
      return { ...state, products: action.payload };
    case "addCustomers":
      return { ...state, customers: action.payload };
    case "addBestelbonnen":
      return { ...state, bestelbonnen: action.payload };
    case "addOffertes":
      return { ...state, offertes: action.payload };

    default:
      return { ...state };
  }
}

const initialState: Data = {
  products: [],
  customers: [],
  offertes: [],
  bestelbonnen: [],
};

const DataProvider: FunctionComponent = ({ children }) => {
  const [state, dispatch] = useReducer(reducer, initialState);
  const { pathname } = useRouter();

  useEffect(() => {
    switch (pathname) {
      case "/":
        if (state.products.length === 0) {
          fetchProducts();
        }

      case "/klanten":
        if (state.customers.length === 0) {
          fetchCustomers();
        }
      default:
        break;
    }
  }, [pathname]);

  const fetchProducts = async () => {
    const [error, products] = await get(`/products/withgroups`);
    dispatch({ type: "addProducts", payload: products });
  };
  const searchProduct = async (product: string) => {
    const [error, products] = await get(`/products/withgroups?q=${product}`);
    dispatch({ type: "addProducts", payload: products });
  };
  const clearSearchProduct = async () => {
    await fetchProducts();
  };

  const fetchCustomers = async () => {
    const [error, customers] = await get(`/customers`);
    dispatch({ type: "addCustomers", payload: customers });
  };
  const searchCustomer = async (query: string) => {
    const [error, customers] = await get(`/customers?q=${query}`);
    dispatch({ type: "addCustomers", payload: customers });
  };
  const clearSearchCustomer = () => {
    fetchCustomers();
  };

  const value = {
    ...state,
    searchCustomer,
    clearSearchCustomer,
    searchProduct,
    clearSearchProduct,
  };

  return (
    <DataProviderContext.Provider value={value}>
      {children}
    </DataProviderContext.Provider>
  );
};

export default DataProvider;
