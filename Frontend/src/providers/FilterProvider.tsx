import {
  createContext,
  FunctionComponent,
  useContext,
  useReducer,
} from "react";
import { FormItemOption } from "src/classes/FormItem";
import { Filter } from "src/types/Filter";

interface IFilterContext {
  filters: Filter;
  updateFilterValue: (filterName: string | undefined, value: any) => void;
}

const FilterContext = createContext<IFilterContext>({} as IFilterContext);

export function useFilters() {
  return useContext(FilterContext);
}

const initialFilterValues: Filter = {
  productgroup: { id: "", name: "" },
  documenttype: { id: "bestelbonnen", name: "Bestelbonnen" },
  customertype: { id: "klanten", name: "Klanten" },
};

function reducer(
  state: Filter,
  action: { type: string; payload: { filterName: string; value: any } }
) {
  switch (action.type) {
    case "update":
      return { ...state, [action.payload.filterName]: action.payload.value };
    default:
      return state;
  }
}

export const FilterProvider: FunctionComponent = ({ children }) => {
  const [filters, dispatch] = useReducer(reducer, initialFilterValues);

  const updateFilterValue = (filterName: string | undefined, value: any) => {
    if (filterName && filterName in filters) {
      dispatch({ type: "update", payload: { filterName, value } });
    }
  };

  const value = {
    filters,
    updateFilterValue,
  };

  return (
    <FilterContext.Provider value={value}>{children}</FilterContext.Provider>
  );
};
