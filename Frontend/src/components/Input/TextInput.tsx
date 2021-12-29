import classNames from "classnames/bind";
import { FunctionComponent } from "react";

interface InputProps extends React.InputHTMLAttributes<HTMLInputElement> {
  label?: string;
  id?: string;
  faulty?: "true" | "false";
  errormessage?: string;
  submitting?: boolean;
  inputClassName?: string;
}

const TextInput: FunctionComponent<InputProps> = ({
  label,
  type = "text",
  autoComplete = "off",
  onChange,
  placeholder,
  id,
  className,
  inputClassName,
  faulty,
  errormessage,
  submitting = false,
  ...props
}) => {
  return (
    <div className={classNames("relative my-auto", className)}>
      <input
        className={classNames(
          "peer border border-green-100 rounded placeholder-transparent pl-0.5 outline-none w-full",
          inputClassName
        )}
        autoComplete={autoComplete}
        onChange={onChange}
        type={type}
        placeholder={placeholder}
        id={id}
        {...props}
      />
      <label
        htmlFor="username"
        className="cursor-text absolute left-0 -top-4 text-sm peer-placeholder-shown:left-1  peer-placeholder-shown:text-gray-400 peer-placeholder-shown:top-1 transition-all peer-focus:-top-4 peer-focus:text-gray-600 peer-focus:text-sm text-gray-100"
      >
        {placeholder}
      </label>
    </div>
  );
};

export default TextInput;
