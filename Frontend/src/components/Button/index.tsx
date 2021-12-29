import classNames from "classnames/bind";
import { FunctionComponent } from "react";

interface ButtonProps extends React.ButtonHTMLAttributes<HTMLButtonElement> {
  children: React.ReactNode;
  btntype?: "primary" | "secondary";
}

const Button: FunctionComponent<ButtonProps> = ({
  children,
  className = "",
  btntype,
  ...props
}) => {
  if (btntype?.toLowerCase() === "primary") {
    return (
      <button
        className={classNames(
          "text-white bg-green-100 hover:bg-green-500 px-4 py-2 rounded",
          className
        )}
        {...props}
      >
        {children}
      </button>
    );
  } else {
    return (
      <button
        className={classNames(
          "rounded border border-green bg-white px-4 py-2 text-green",
          className
        )}
        {...props}
      >
        {children}
      </button>
    );
  }
};

export default Button;
