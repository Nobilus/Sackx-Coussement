import React, { FunctionComponent, useState } from "react";
import { FormItemOption } from "src/classes/FormItem";
import DropdownWrapper from "./DropdownWrapper";
import DropdownItem from "./DropdownItem";

interface DropdownProps {
  options: Array<FormItemOption>;
  placeholder: string;
  className?: string;
  onChange: any;
  name: string;
}

const Dropdown: FunctionComponent<DropdownProps> = ({
  options,
  placeholder,
  className,
  onChange,
  name,
}) => {
  const [selected, setSelected] = useState<FormItemOption>();

  function handleChange(e: { id: string; name: string }) {
    setSelected(e);
    onChange(e, name);
  }

  return (
    <DropdownWrapper
      onChange={handleChange}
      value={selected}
      placeholder={placeholder}
      className={className}
    >
      {options.map((item, index) => (
        <DropdownItem
          value={item}
          key={`dropdownItem-${index}`}
          title={item.name}
        />
      ))}
    </DropdownWrapper>
  );
};

export default React.memo(Dropdown);
