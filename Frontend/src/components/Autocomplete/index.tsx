import classNames from "classnames";
import { useCombobox } from "downshift";
import { forwardRef, FunctionComponent, useState } from "react";
import { MdExpandMore, MdExpandLess } from "react-icons/md";

interface AutocompleteProps {
  placeholder: string;
  items: Array<any>;
  className?: string;
  selectedItem?: any;
  handleSelectedItemChange?: any;
  name?: string;
  id?: string;
}

const Autocomplete: FunctionComponent<AutocompleteProps> = forwardRef(
  (
    {
      children,
      placeholder,
      items,
      className,
      selectedItem,
      handleSelectedItemChange,
      name,
      id,
    },
    ref
  ) => {
    const [inputItems, setInputItems] = useState(items);

    const sendValues = (e: any) => {
      const value = { ...e, name, id };
      handleSelectedItemChange(value);
    };

    const {
      isOpen,
      getToggleButtonProps,
      getLabelProps,
      getMenuProps,
      getInputProps,
      getComboboxProps,
      highlightedIndex,
      getItemProps,
    } = useCombobox({
      items: inputItems,
      selectedItem,
      onSelectedItemChange: sendValues,
      onInputValueChange: ({ inputValue }) => {
        setInputItems(
          items.filter((item) =>
            //@ts-ignore
            item.toLowerCase().startsWith(inputValue.toLowerCase())
          )
        );
      },
    });

    const DDIcon = forwardRef((props, ref) => {
      return (
        <div aria-label={"toggle menu"} {...getToggleButtonProps()} ref={ref}>
          <MdExpandMore
            type="button"
            className="h-5 w-5 fill-black cursor-pointer outline-none"
          />
        </div>
      );
    });

    return (
      <div className={classNames(className)} {...getComboboxProps()}>
        <label {...getLabelProps()} className="relative block">
          <span className="sr-only">{`${placeholder} dropdown`}</span>
          <input
            placeholder={placeholder}
            className="placeholder:italic placeholder:text-gray-400 block bg-white border w-full border-green-100 rounded py-2 pl-2 pr-3 shadow-sm sm:text-sm"
            {...getInputProps()}
          />
          <span className="absolute inset-y-0 right-0 flex items-center pr-2">
            <DDIcon />
          </span>
        </label>

        <ul
          className={classNames(
            "absolute z-10  py-1 mt-1 overflow-auto text-base bg-white rounded-md shadow-lg max-h-60 ring-1 ring-green ring-opacity-5 focus:outline-none sm:text-sm"
          )}
          {...getMenuProps()}
        >
          {isOpen &&
            inputItems.map((item, index) => (
              <li
                className={
                  "cursor-default select-none relative py-2 pl-2 pr-2 text-green-900 truncate"
                }
                style={
                  highlightedIndex === index
                    ? { backgroundColor: "#bde4ff" }
                    : {}
                }
                key={`${item}${index}`}
                {...getItemProps({ item, index })}
              >
                {item}
              </li>
            ))}
        </ul>
      </div>
    );
  }
);

export default Autocomplete;
