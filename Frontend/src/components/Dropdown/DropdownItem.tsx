import { Listbox } from "@headlessui/react";
import classNames from "classnames/bind";
import { FunctionComponent } from "react";
import { MdDone } from "react-icons/md";

interface DropdownItemProps {
  value: any;
  title: string;
}

const DropdownItem: FunctionComponent<DropdownItemProps> = ({
  value,
  title,
}) => {
  return (
    <Listbox.Option
      className={({ active }) =>
        classNames("cursor-default select-none relative py-2 pl-10 pr-4", {
          "text-green-900 bg-green-100": active,
          "text-green-900": !active,
        })
      }
      value={value}
    >
      {({ selected }) => (
        <>
          <span
            className={classNames("block truncate", {
              "font-medium": selected,
              "font-normal": !selected,
            })}
          >
            {title}
          </span>
          {selected && (
            <span
              className={"absolute inset-y-0 left-0 flex items-center pl-3"}
            >
              <MdDone />
            </span>
          )}
        </>
      )}
    </Listbox.Option>
  );
};

export default DropdownItem;
