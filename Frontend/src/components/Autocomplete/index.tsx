import classNames from "classnames";
import { useCombobox } from "downshift";
import { FunctionComponent, useState } from "react";
import { MdExpandMore, MdExpandLess } from "react-icons/md";

interface AutocompleteProps {
  placeholder: string;
  items: Array<any>;
  className?: string;
}

const Autocomplete: FunctionComponent<AutocompleteProps> = ({
  children,
  placeholder,
  items,
  className,
}) => {
  const [inputItems, setInputItems] = useState(items);

  const {
    isOpen,
    selectedItem,
    getToggleButtonProps,
    getLabelProps,
    getMenuProps,
    getInputProps,
    getComboboxProps,
    highlightedIndex,
    getItemProps,
  } = useCombobox({
    items: inputItems,
    onInputValueChange: ({ inputValue }) => {
      setInputItems(
        items.filter((item) =>
          //@ts-ignore
          item.toLowerCase().startsWith(inputValue.toLowerCase())
        )
      );
    },
  });

  return (
    <div className={classNames(className)} {...getComboboxProps()}>
      {/* <input {...getInputProps()} /> */}
      <label {...getLabelProps()} className="relative block">
        <span className="sr-only">{`${placeholder} dropdown`}</span>
        <input
          placeholder={placeholder}
          className=" placeholder:text-black block bg-white border border-green-100 rounded py-2 pl-2 pr-3 shadow-sm sm:text-sm"
          {...getInputProps()}
        />
        <span className="absolute inset-y-0 right-0 flex items-center pr-2">
          <MdExpandMore
            {...getToggleButtonProps()}
            type="button"
            className="h-5 w-5 fill-black cursor-pointer outline-none"
            aria-label={"toggle menu"}
          />
        </span>
      </label>
      {isOpen && (
        <ul
          className="absolute z-10  py-1 mt-1 overflow-auto text-base bg-white rounded-md shadow-lg max-h-60 ring-1 ring-green ring-opacity-5 focus:outline-none sm:text-sm"
          {...getMenuProps()}
        >
          {inputItems.map((item, index) => (
            <li
              className={
                "cursor-default select-none relative py-2 pl-2 pr-2 text-green-900 truncate"
              }
              style={
                highlightedIndex === index ? { backgroundColor: "#bde4ff" } : {}
              }
              key={`${item}${index}`}
              {...getItemProps({ item, index })}
            >
              {item}
            </li>
          ))}
        </ul>
      )}
    </div>
  );

  //   return (
  //     <Downshift
  //       onChange={(selection) =>
  //         console.log(
  //           selection ? `You selected ${selection}` : "Selection Cleared"
  //         )
  //       }
  //       itemToString={(item) => (item ? item : "")}
  //     >
  //       {({
  //         getInputProps,
  //         getItemProps,
  //         getLabelProps,
  //         getMenuProps,
  //         isOpen,
  //         inputValue,
  //         highlightedIndex,
  //         selectedItem,
  //       }) => (
  //         <div className={classNames(className)}>
  //           <div>
  //             <label {...getLabelProps()} className="relative block">
  //               <span className="sr-only">{`${placeholder} dropdown`}</span>
  //               <input
  //                 placeholder={placeholder}
  //                 className=" placeholder:text-black block bg-white w-full border border-green-100 rounded py-2 pl-2 pr-3 shadow-sm sm:text-sm"
  //                 {...getInputProps()}
  //               />
  //               <span className="absolute inset-y-0 right-0 flex items-center pr-2">
  //                 <MdExpandMore className="h-5 w-5 fill-black" />
  //               </span>
  //             </label>
  //             <ul className="rounded bg-gray-100" {...getMenuProps()}>
  //               {isOpen
  //                 ? items
  //                     .filter(
  //                       (item) =>
  //                         !inputValue ||
  //                         item.toLowerCase().includes(inputValue.toLowerCase())
  //                     )
  //                     .map((item, index) => (
  //                       <li
  //                         {...getItemProps({
  //                           key: item,
  //                           index,
  //                           item,
  //                           className: `py-2 px-2 ${
  //                             highlightedIndex === index
  //                               ? "bg-white font-bold"
  //                               : "bg-gray-100"
  //                           }`,
  //                         })}
  //                       >
  //                         {item}
  //                       </li>
  //                     ))
  //                 : null}
  //             </ul>
  //           </div>
  //         </div>
  //       )}
  //     </Downshift>
  //   );
};

export default Autocomplete;
