import { useRouter } from "next/router";
import {
  createContext,
  FunctionComponent,
  useContext,
  useEffect,
  useReducer,
  useState,
} from "react";
import { Customer } from "src/types/Customer";
import { Data } from "src/types/Data";
import { NewOrder, Order, OrderDetail } from "src/types/Order";
import { Product, ProductWithGroupname } from "src/types/Products";
import { Unit } from "src/types/Unit";
import { get } from "src/utils/api";

interface IDataProviderContext {
  searchCustomer: (query: string) => Promise<void>;
  clearSearchCustomer: () => void;
  searchProduct: (product: string) => Promise<void>;
  searchSingleProduct: (product: string) => Array<Product>;
  clearSearchProduct: () => Promise<void>;
  validateVatNumber: (vatNumber: string) => Promise<void>;
  storeOrder: (newOrder: Array<NewOrder>) => void;
  setOrderType: (type: string) => void;
  productsWithGroupname: Array<ProductWithGroupname>;
  products: Array<Product>;
  customers: Customer[];
  offertes: Array<Order>;
  bestelbonnen: Array<Array<Order>>;
  loading: boolean;
  customer: null | Customer;
  units: null | Array<Unit>;
  order: undefined | Array<NewOrder>;
}

const DataProviderContext = createContext<IDataProviderContext>(
  {} as IDataProviderContext
);

export function useData() {
  return useContext(DataProviderContext);
}

function reducer(state: Data, action: { type: string; payload?: any }) {
  switch (action.type) {
    case "addProductsWithGroupname":
      return { ...state, productsWithGroupname: action.payload };
    case "addAllProducts":
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
    case "storeOrder":
      return { ...state, order: action.payload };
    case "setOrderType":
      return { ...state, orderType: action.payload };
    default:
      return { ...state };
  }
}

const initialState: Data = {
  productsWithGroupname: [],
  products: [],
  customers: [],
  offertes: [],
  bestelbonnen: [],
  units: null,
  customer: null,
  loading: false,
  order: [],
  orderType: undefined,
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
          fetchAllProducts();
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
    setLoadingTrue();
    const [error, products] = await get(`/products/withgroups`);
    setLoadingFalse();
    dispatch({ type: "addProductsWithGroupname", payload: products });
  };

  const fetchAllProducts = async () => {
    setLoadingTrue();
    const [error, products] = await get("/products");
    setLoadingFalse();
    dispatch({ type: "addAllProducts", payload: products });
  };

  const searchProduct = async (product: string) => {
    setLoadingTrue();
    const [error, products] = await get(`/products/withgroups?q=${product}`);
    setLoadingFalse();
    dispatch({ type: "addProductsWithGroupname", payload: products });
  };

  const searchSingleProduct = async (product: string) => {
    setLoadingTrue();
    const [error, products] = await get(`/products?q=${product}`);
    setLoadingFalse();
    return products as Array<Product>;
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

  const storeOrder = (order: Array<NewOrder>) => {
    dispatch({ type: "storeOrder", payload: order });
  };

  const setOrderType = (type: string) => {
    dispatch({ type: "setOrderType", payload: type });
  };

  const value = {
    ...state,
    searchCustomer,
    clearSearchCustomer,
    searchProduct,
    clearSearchProduct,
    validateVatNumber,
    searchSingleProduct,
    storeOrder,
    setOrderType,
  };

  return (
    <DataProviderContext.Provider value={value}>
      {children}
    </DataProviderContext.Provider>
  );
};

export default DataProvider;
