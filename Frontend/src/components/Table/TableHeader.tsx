import classNames from "classnames/bind";
import { FunctionComponent } from "react";

interface THProps {
  editable?: boolean;
  onChange?: any;
  value?: string;
  placeholder?: string;
  className?: string;
}

const TableHeader: FunctionComponent<THProps> = ({
  children,
  editable,
  onChange,
  value,
  placeholder,
  className,
}) => {
  if (editable) {
    return (
      <div className={classNames(className)}>
        <input
          value={value}
          className={classNames(
            "mx-2 mb-2 bg-gray-100 placeholder:text-green-25",
            { "text-xl font-body font-semibold": !editable },
            {
              "text-baseline font-body font-regular border border-green-100 rounded placeholder-transparent pl-4 py-2 outline-none w-max bg-white":
                editable,
            }
          )}
          disabled={!editable}
          onChange={onChange}
          placeholder={placeholder}
        />
        <hr className="border-green-25" />
      </div>
    );
  } else {
    return (
      <div>
        {children && (
          <h1 className="text-xl font-body font-semibold text-green-25 mx-2 mb-2">
            {children}
          </h1>
        )}
        <hr className="border-green-25" />
      </div>
    );
  }
};

export default TableHeader;
