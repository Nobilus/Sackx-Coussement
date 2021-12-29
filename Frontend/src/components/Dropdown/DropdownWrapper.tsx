import { Listbox, Transition } from "@headlessui/react";
import classNames from "classnames";
import { FunctionComponent, useState } from "react";
import { MdExpandMore } from "react-icons/md";

interface DropdownWrapperProps {
  value: any;
  onChange: any;
  placeholder: string;
  className?: string;
}

const DropdownWrapper: FunctionComponent<DropdownWrapperProps> = ({
  children,
  value,
  onChange,
  className,
  placeholder,
}) => {
  return (
    <Listbox as="div" value={value} onChange={onChange} className={className}>
      <Listbox.Button className="relative rounded border border-green bg-white px-4 py-2 text-greenw-full  pl-7 pr-10 text-left cursor-default">
        <span className="block truncate">{placeholder}</span>
        <span className="absolute inset-y-0 right-0 flex items-center pr-4 pointer-events-none">
          <MdExpandMore className="w-5 h-5" />
        </span>
      </Listbox.Button>

      <Transition
        leave="transition ease-in duration-100"
        leaveFrom="opacity-100"
        leaveTo="opacity-0"
      >
        <Listbox.Options className="absolute z-10 w-full py-1 mt-1 overflow-auto text-base bg-white rounded-md shadow-lg max-h-60 ring-1 ring-blue ring-opacity-5 focus:outline-none sm:text-sm">
          {children}
        </Listbox.Options>
      </Transition>
    </Listbox>
  );
};

export default DropdownWrapper;
