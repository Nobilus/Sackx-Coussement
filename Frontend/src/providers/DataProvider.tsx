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
import { Order, OrderDetail } from "src/types/Order";
import { Product } from "src/types/Products";
import { Unit } from "src/types/Unit";
import { get } from "src/utils/api";

interface IDataProviderContext {
  searchCustomer: (query: string) => Promise<void>;
  clearSearchCustomer: () => void;
  searchProduct: (product: string) => Promise<void>;
  clearSearchProduct: () => Promise<void>;
  validateVatNumber: (vatNumber: string) => Promise<void>;
  products: any;
  customers: Customer[];
  offertes: Array<Order>;
  bestelbonnen: Array<Array<Order>>;
  loading: boolean;
  customer: null | Customer;
  units: null | Array<Unit>;
}

const DataProviderContext = createContext<IDataProviderContext>(
  {} as IDataProviderContext
);

export function useData() {
  return useContext(DataProviderContext);
}

function reducer(state: Data, action: { type: string; payload?: any }) {
  switch (action.type) {
    case "addProducts":
      return { ...state, products: action.payload };
    case "addCustomers":
      return { ...state, customers: action.payload };
    case "addBestelbonnen":
      return { ...state, bestelbonnen: action.payload };
    case "addOffertes":
      return { ...state, offertes: action.payload };
    case "toggleLoading":
      return { ...state, loading: action.payload.loading };
    case "setCustomer":
      return { ...state, customer: action.payload };
    case "addUnits":
      return { ...state, units: action.payload };
    default:
      return { ...state };
  }
}

const initialState: Data = {
  products: [],
  customers: [],
  offertes: [],
  bestelbonnen: [],
  units: null,
  customer: null,
  loading: false,
};

const DataProvider: FunctionComponent = ({ children }) => {
  const [state, dispatch] = useReducer(reducer, initialState);
  const { pathname } = useRouter();

  useEffect(() => {
    switch (pathname) {
      case "/":
        if (state.products.length === 0) {
          fetchProducts();
          fetchUnits();
        }

      case "/klanten":
        if (state.customers.length === 0) {
          fetchCustomers();
        }
      case "/documents":
        if (state.bestelbonnen.length === 0) {
          fetchBestelbons();
        }
        if (state.offertes.length === 0) {
          fetchOffertes();
        }
      default:
        break;
    }
  }, [pathname]);

  const setLoadingTrue = () => {
    dispatch({ type: "toggleLoading", payload: { loading: true } });
  };
  const setLoadingFalse = () => {
    dispatch({ type: "toggleLoading", payload: { loading: false } });
  };

  const fetchProducts = async () => {
    const [error, products] = await get(`/products/withgroups`);
    dispatch({ type: "addProducts", payload: products });
  };
  const searchProduct = async (product: string) => {
    setLoadingTrue();
    const [error, products] = await get(`/products/withgroups?q=${product}`);
    setLoadingFalse();
    dispatch({ type: "addProducts", payload: products });
  };
  const clearSearchProduct = async () => {
    await fetchProducts();
  };

  const fetchCustomers = async () => {
    setLoadingTrue();
    const [error, customers] = await get(`/customers`);
    setLoadingFalse();
    dispatch({ type: "addCustomers", payload: customers });
  };
  const searchCustomer = async (query: string) => {
    setLoadingTrue();
    const [error, customers] = await get(`/customers?q=${query}`);
    setLoadingFalse();
    dispatch({ type: "addCustomers", payload: customers });
  };
  const clearSearchCustomer = () => {
    fetchCustomers();
  };

  const fetchBestelbons = async () => {
    setLoadingTrue();
    const [error, bestelbons] = await get(`/bestelbons`);
    setLoadingFalse();
    dispatch({ type: "addBestelbonnen", payload: bestelbons });
  };

  const fetchOffertes = async () => {
    setLoadingTrue();
    const [error, offertes] = await get("/offertes");
    setLoadingFalse();
    dispatch({ type: "addOffertes", payload: offertes });
  };

  const fetchUnits = async () => {
    setLoadingTrue();
    const [error, units] = await get("/units");
    setLoadingFalse();
    dispatch({ type: "addUnits", payload: units });
  };

  const validateVatNumber = async (vatNumber: string) => {
    setLoadingTrue();
    const [error, customer] = await get(`/customer/validate/${vatNumber}`);
    setLoadingFalse();
    dispatch({ type: "setCustomer", payload: customer });
  };

  const value = {
    ...state,
    searchCustomer,
    clearSearchCustomer,
    searchProduct,
    clearSearchProduct,
    validateVatNumber,
  };

  return (
    <DataProviderContext.Provider value={value}>
      {children}
    </DataProviderContext.Provider>
  );
};

export default DataProvider;
